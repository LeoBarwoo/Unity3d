﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interfaces {
   public interface ISceneController {
        void LoadResources();
    }

    public interface UserAction {
        int GetScore();
        void Restart();
        bool GetGameState();
        void MovePlayer(Vector3 speed);
    }

    public enum SSActionEventType: int { Started, Completed}

    public interface SSActionCallback {
        void SSActionCallback(SSAction source);
    }
}
