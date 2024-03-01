////-----------------------------FOR SINGLETON ------------------------------------------
//using DesignPatterns.Singleton;

//Singleton object1 = Singleton.Instance();
//Singleton object2 = Singleton.Instance();

//if (object1 == object2)
//{
//    Console.WriteLine("These objects are the same");
//}



//-----------------------------FOR FACTORY PATTERN --------------------------------------
//using DesignPatterns.Factory.NetworkFactory;

//NetworkFactory factory= new NetworkFactory();

//var ping = factory.GetNetworkInstance("ping");
//var dns = factory.GetNetworkInstance("dns");
//var arp = factory.GetNetworkInstance("arp");

//ping.SendRequest("24.242.566", 2);
//dns.SendRequest("3.131.23", 4);
//arp.SendRequest("12.312.31.2", 4);



//-----------------------------FOR FACADE PATTERN --------------------------------------
//using DesignPatterns.Facade;

//NetworkFacade networkFacade = new NetworkFacade("8.8.8.8","UDP");

//networkFacade.BuildNetworkLayer();
//networkFacade.SendPacketOverNetwork();



//-----------------------------FOR ADAPTER PATTERN --------------------------------------
//using DesignPatterns.Adapter;
//using DesignPatterns.Adapter.DataProccessor;
//using DesignPatterns.Adapter.Network;

//INetworkClient network=new NetworkClient();
//network.SendRequest("8.3.3.1");

//IDataProcessor dataProcessor = new DataProccessor();
//dataProcessor.SendNetworkRequest("3.3.1.2", "imakey32");

//NetworkAdapter adapter = new NetworkAdapter(dataProcessor);
//adapter.SendRequest("9.1.1.3");



//-----------------------------FOR PROXY PATTERN --------------------------------------
//using DesignPatterns.Proxy;

//ISuperSecretDatabase superSecretDatabase = new SuperSecretDatabaseProxy("testdb", "Passowrd");
//superSecretDatabase.DisplayDatabaseName();



//-----------------------------FOR CHAIN OF RESPONSIBILITY PATTERN --------------------------------------
//using DesignPatterns.ChainOfResponsibility;

//IChain obj1 = new SendSSH();
//IChain obj2 = new SendPing();
//IChain obj3 = new SendARP();

//obj1.SetNext(obj2);
//obj2.SetNext(obj3);

//NetworkModel request = new NetworkModel("3.3.1.1", false);
//obj1.SendRequest(request);



//-----------------------------FOR STRATEGY PATTERN --------------------------------------
using DesignPatterns.Strategy;

Context context = new Context(new ARP());
Context contextTwo= new Context(new Ping());
Context contextThree= new Context(new DNS());

context.ExecuteStrategy();
contextTwo.ExecuteStrategy();
contextThree.ExecuteStrategy();


