#!/usr/bin/env python3
# -*- coding: utf-8 -*-

import configparser

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
        except Exception:
            print('File not found or wrong format')
