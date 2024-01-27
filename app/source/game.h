#ifndef GAME_H
#define GAME_H

#include <core/x-platform/scene.h>
#include <core/components/text.h>
#include "entertainer.h"

class Game : public IScene
{
public:
    Game();

    int mood;

    Entertainer* entertainer;
    Text* moodText;
    ITime *timer;
    bool isEntertainerPresent;

    Text* selector;
    int option;
    bool isGameOver;
    float clowndance;

    Text* text1;
    Text* text2;

    void Init();
    void Update();
    void UpdateAfterPhysics();
};

#endif
