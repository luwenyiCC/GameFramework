﻿//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2019 Jiang Yin. All rights reserved.
// Homepage: http://gameframework.cn/
// Feedback: mailto:jiangyin@gameframework.cn
//------------------------------------------------------------

namespace GameFramework.Config
{
    internal sealed partial class ConfigManager : GameFrameworkModule, IConfigManager
    {
        private sealed class LoadConfigInfo
        {
            private readonly LoadType m_LoadType;
            private readonly object m_UserData;

            public LoadConfigInfo(LoadType loadType, object userData)
            {
                m_LoadType = loadType;
                m_UserData = userData;
            }

            public LoadType LoadType
            {
                get
                {
                    return m_LoadType;
                }
            }

            public object UserData
            {
                get
                {
                    return m_UserData;
                }
            }
        }
    }
}
