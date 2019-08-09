using System;
using System.Collections;

namespace trainComposition
{
	class Train
	{
		public int count = 0;
		
		public struct Wagon{
			public int hierarchyLevel;
		}
		
		public Wagon newWagon(int hierarchy){
			Wagon wagon = new Wagon();
			wagon.hierarchyLevel = hierarchy;
			count++;
			return wagon;
		}
		
		public Queue newTrain(){
			Queue train =  new Queue();
			return train;
		}
		
		public void enqueueWagon(int hierarchy, Queue train){
			train.Enqueue(newWagon(hierarchy));
		}
		
		public int dequeueWagon(Queue train){
			Wagon wagon = new Wagon();
			wagon = (Wagon) train.Dequeue();
			return wagon.hierarchyLevel;
		}
	}
	
	class Program{
		public static void Main(string[] args)
		{	
			Train tr = new Train();
			var train = tr.newTrain();
			tr.enqueueWagon(7, train);
			tr.enqueueWagon(10, train);
			for(int i = 0; i < tr.count; i++){
				Console.WriteLine("{0}º vagão a sair: {1}; ", i+1, tr.dequeueWagon(train));
			}
			Console.ReadKey(true);
		}
	}
}