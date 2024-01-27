#ifndef SPLASH_H
#define SPLASH_H

#include <core/x-platform/scene.h>
#include <core/components/sprite.h>

class Splash : public IScene
{
public:
    Splash();

    ITime *timer;

    void Init();
    void Update();
    void UpdateAfterPhysics();
};

#endif
