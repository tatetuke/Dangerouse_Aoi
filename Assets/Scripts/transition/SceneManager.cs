﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//UnityのBuildSettingsに登録してあるシーン名と完全一致でここに記述してください
public enum GameScenes
{
 SampleScene,
 GameScene,
 GameOverScene,
 temprary
}

namespace BirdStrike.MIKOMA.Scripts.Utilities.SceneDataPacks
{
    /// <summary>
    /// シーンをまたいでデータを受け渡すときに利用する
    /// </summary>
    public abstract class SceneDataPack
    {
        /// <summary>
        /// 前のシーン
        /// </summary>
        public abstract GameScenes PreviousGameScene { get; }

        /// <summary>
        /// 前シーンで追加ロードしていたシーン一覧
        /// </summary>
        public abstract GameScenes[] PreviousAdditiveScene { get; }
    }

    /// <summary>
    /// デフォルト実装
    /// </summary>
    public class DefaultSceneDataPack : SceneDataPack
    {
        private readonly GameScenes _prevGameScenes;
        private readonly GameScenes[] _additiveScenes;

        public GameScenes[] AdditiveScenes
        {
            get { return _additiveScenes; }
        }

        public override GameScenes PreviousGameScene
        {
            get { return _prevGameScenes; }
        }

        public override GameScenes[] PreviousAdditiveScene
        {
            get { return null; }
        }

        public DefaultSceneDataPack(GameScenes prev, GameScenes[] additive)
        {
            _prevGameScenes = prev;
            _additiveScenes = additive;
        }
    }
}
