using System;
using NUnit.Framework;
using System.Collections;

namespace trainComposition
{
	[TestFixture]
	public class trainCompositionTest
	{
		[Test]
		public void testNewTrain(){
			Train tr = new Train();
			var train = tr.newTrain();
			Assert.NotNull(train);
		}
		
		[Test]
		public void testNewWagon()
		{
			Train tr = new Train();
			var train = tr.newTrain();
			Assert.IsNotNull(tr.newWagon(0));
		}
		
		[Test]
		public void testEnqueueWagon(){
			Train tr = new Train();
			var train = tr.newTrain();
			Assert.DoesNotThrow(() => tr.enqueueWagon(1, train));
		}
		
		[Test]
		public void testeDequeueWagon(){
			Train tr = new Train();
			var train = tr.newTrain();
			Assert.DoesNotThrow(() =>{
			                    	tr.enqueueWagon(1, train);
			                    	tr.dequeueWagon(train);
			                    });
		}
		
	}
	
		
		
}
