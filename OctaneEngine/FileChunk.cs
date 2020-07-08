﻿namespace OctaneDownloadEngine
{
    class FileChunk
    {
        public int start { get; set; }
        public int end { get; set; }

        public FileChunk(){}

        public FileChunk(int startByte, int endByte)
        {
            start = startByte;
            end = endByte;
        }
    }
}