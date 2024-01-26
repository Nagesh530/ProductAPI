namespace ProductWebApiTest
{
    public class HealthCheckControllerTest
    {
        private HealthCheckController _healthCheckController;
        private Mock<ICacheHealthChecker> _cacheHealthChecker;

        [SetUp]
        public void Setup()
        {
            _cacheHealthChecker = new Mock<ICacheHealthChecker>();
            _healthCheckController = new HealthCheckController(_cacheHealthChecker.Object);
        }

        [Test]
        public async Task HealthCheck_ReturnsOkResultWhenHealthy()
        {

            _cacheHealthChecker.Setup(checker => checker.CheckHealthAsync()).
                ReturnsAsync(new HealthResult(HealthStatus.Healthy, "Server is healthy"));
           
            var result = await _healthCheckController.HealthCheck();

            Assert.IsInstanceOf<ObjectResult>(result);
            Assert.AreEqual(200, ((ObjectResult)result).StatusCode);
        }

        [Test]
        public async Task HealthCheck_Returns500ResultWhenHealthy()
        {

            _cacheHealthChecker.Setup(checker => checker.CheckHealthAsync()).
                ReturnsAsync(new HealthResult(HealthStatus.Unhealthy, "Server is Unhealthy"));

            var result = await _healthCheckController.HealthCheck();

            Assert.IsInstanceOf<ObjectResult>(result);
            Assert.AreEqual(500, ((ObjectResult)result).StatusCode);
        }
    }
}
