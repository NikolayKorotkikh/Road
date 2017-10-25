#!/usr/bin/env python3
# -*- coding: utf-8 -*-

from twisted.internet import reactor, protocol

from Server.Config import Config


class Server(protocol.Protocol):
    def connectionMade(self):
        print('Unity connected')
        self.transport.write(b"send from server")


    def dataReceived(self, data):
        print(data.decode("utf-8"))


    def connectionLost(self, reason):
        print('Unity disconnected')


class ServerFactory(protocol.ServerFactory):
    protocol = Server


if __name__ == '__main__':
    config = Config('config.ini');
    config = config.get()
    factory = ServerFactory()
    reactor.listenTCP(9999, factory)

    print('Server start...')
    reactor.run()

