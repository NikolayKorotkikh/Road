#!/usr/bin/env python3
# -*- coding: utf-8 -*-

import configparser
import os

class Config():

    def __init__(self, file):
        self.config = configparser.ConfigParser();
        self.file = file
        self.dict = {}


    def get(self):
        try:
            self.config.read(self.file)
            for section in self.config.sections():
                for options in self.config.options(section):
                    self.dict[options] = self.config.get(section, options)
            return self.dict
        except FileNotFoundError:
            print('File not found')
        except configparser.ParsingError:
            print('Wrong format')
