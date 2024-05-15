# Named Pipe Wrapper for .Net 8.0

## This repository was forked from NamedPipeWrapper 1.4.0 creadted by Andrew C. Dvorak and the original project url is https://github.com/acdvorak/named-pipe-wrapper.

A simple, easy to use, strongly-typed wrapper around .NET 5.0 named pipes.

# NuGet Package

Available as a [NuGet package](https://www.nuget.org/packages/NetCoreNamedPipeWrapper/).

# Features

- Create named pipe servers that can handle multiple client connections simultaneously.
- Send strongly-typed messages between clients and servers: any serializable .NET object can be sent over a pipe and will be automatically serialized/deserialized, including cyclical references and complex object graphs.
- Messages are sent and received asynchronously on a separate background thread and marshalled back to the calling thread (typically the UI).
- Supports large messages - up to 300 MiB.

# Usage

Server:

```csharp
var server = new NamedPipeServer<SomeClass>("MyServerPipe");

server.ClientConnected += delegate(NamedPipeConnection<SomeClass> conn)
    {
        Console.WriteLine($"Client {conn.Id} is now connected!");
        conn.PushMessage(new SomeClass { Text: "Welcome!" });
    };

server.ClientMessage += delegate(NamedPipeConnection<SomeClass> conn, SomeClass message)
    {
        Console.WriteLine($"Client {conn.Id} says: {message.Text}");
    };

// Start up the server asynchronously and begin listening for connections.
// This method will return immediately while the server runs in a separate background thread.
server.Start();

// ...
```

Client:

```csharp
var client = new NamedPipeClient<SomeClass>("MyServerPipe");

client.ServerMessage += delegate(NamedPipeConnection<SomeClass> conn, SomeClass message)
    {
        Console.WriteLine($"Server says: {message.Text}");
    };

// Start up the client asynchronously and connect to the specified server pipe.
// This method will return immediately while the client runs in a separate background thread.
client.Start();

// ...
```

# MIT License

Named Pipe Wrapper for .NET is licensed under the [MIT license](LICENSE.txt).
