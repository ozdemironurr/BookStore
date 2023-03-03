
using BookStore.TokenOperations;
using BookStore.TokenOperations;
using BookStore.TokenOperations.Models;
using WebApi.DBOperations;

namespace BookStore.Application.CustomerOperations.Commands.RefreshToken
{
    public class RefreshTokenCommand
    {
        public string RefreshToken { get; set; }
        private readonly IBookStoreDbContext _dbContext;
        private readonly IConfiguration _configuration;

        public RefreshTokenCommand(IBookStoreDbContext dbContext, IConfiguration mapper)
        {
            _dbContext = dbContext;
            _configuration = mapper;
        }

        public Token Handle()
        {
            var customer = _dbContext.Customers.FirstOrDefault(x => x.RefresToken == RefreshToken && x.RefreshTokenExpDate > DateTime.Now);
            if (customer !=null)
            {
                TokenHandler handler = new TokenHandler(_configuration);
                Token token = handler.CreateAccesToken(customer);

                customer.RefresToken = token.RefreshToken;
                customer.RefreshTokenExpDate = token.Expiration.AddMinutes(5);
                _dbContext.SaveChanges();

                return token;

            }
            else
            {
                throw new InvalidOperationException("Valid bir refresh token bulunamadı !");
            }
        }


    }
}
