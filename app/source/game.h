#ifndef GAME_H
#define GAME_H

#include <core/x-platform/scene.h>
#include <core/components/text.h>

class Game : public IScene
{
public:
    Game();

    Text *moodText;
    Text *entertainerText;
    Text *text1;
    Text *text2;
    Text *text3;
    ITime *timer;
    bool isEntertainerPresent;

    Text *selector;
    Sprite *entertainer;
    int option;
    bool isGameOver;
    float clowndance;

    void Init();
    void Update();
    void UpdateAfterPhysics();
};

#endif
