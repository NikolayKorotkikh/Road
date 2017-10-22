import unittest
import tempfile
import shutil
from os import path
from Server.Config import Config

class TestConfig(unittest.TestCase):


    def setUp(self):
        self.test_dir = tempfile.mkdtemp()


    def tearDown(self):
        shutil.rmtree(self.test_dir)


    def test_file_is_exist_and_format_true(self):
        f = open(path.join(self.test_dir, 'test.txt'), 'w')
        f.write('[Network]\nhost = 127.0.0.1\nport = 9999')
        f = path.join(self.test_dir, 'test.txt')

        dict = {}
        dict['host'] = '127.0.0.1'
        dict['port'] = '9999'

        config = Config(f)
        t = config.get()
        self.assertEqual(dict,  config.get())


if __name__ == '__main__':
    unittest.main()