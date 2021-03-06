﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanesGame.GameGraphics
{
    interface IEngine
    {
        BufferedGraphicsContext GraphicsContext { get; set; }

        BufferedGraphics GraphicsBuffer { get; set; }
        
        Tile[,] Tiles { get; set; }
        int TilesNumberOfRows { get; set; }

        int TilesNumberOfCollumns { get; set; }

        void Draw();

        void SetTileMatrixSize(int rows, int collums);

        void UpdateTile(int x, int y, Color myColor);
    }
}
