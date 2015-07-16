﻿/*This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
If a copy of the MPL was not distributed with this file, You can obtain one at
http://mozilla.org/MPL/2.0/.

The Original Code is the TSOClient.

The Initial Developer of the Original Code is
ddfczm. All Rights Reserved.

Contributor(s): ______________________________________.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tso.world.model
{
    public struct WallTile
    {
        public WallSegments Segments;

        //the patterns of each side of the tile's wall.
        public ushort TopLeftPattern;
        public ushort TopRightPattern;
        public ushort BottomLeftPattern;
        public ushort BottomRightPattern;

        //the style of the wall at the top left and top right. bottom left and bottom right are to be obtained from the tiles in those directions.
        //1 generally means "normal wall". Not sure how to deal with cutouts while keeping these as "normal wall".
        public ushort TopLeftStyle;
        public ushort TopRightStyle;

        public bool TopLeftThick
        {
            get
            {
                return TopLeftStyle == 1 || TopLeftStyle == 255;
            }
        }

        public bool TopRightThick
        {
            get
            {
                return TopRightStyle == 1 || TopRightStyle == 255;
            }
        }

        //Placement never seems to be not zero, so it's not included for now.
        //don't include below information when serializing as it will be generated by the client upon load

        public ushort ObjSetTLStyle; //custom styles set by objects (windows and doors)
        public ushort ObjSetTRStyle;

        public bool TopLeftDoor;
        public bool TopRightDoor;

        public WallSegments OccupiedWalls;
    }
}
