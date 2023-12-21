
using EvaluationSampleCode;

namespace EvaluationSampleCodeUnitTests
{
    [TestClass]
    public class ReservationTests
    {

        [TestMethod]
        public void CanBeCancelledByTest_ShouldReturnFalse()
        {
            var reservation = new Reservation(new User { IsAdmin = false });
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = false });
            Assert.IsFalse(result);
        }

        [TestMethod]

        public void CanBeCancelledByTest_ShouldReturnTrue()
        {
            var reservation = new Reservation(new User { IsAdmin = false });
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });
            Assert.IsTrue(result);
        }
    }
}
