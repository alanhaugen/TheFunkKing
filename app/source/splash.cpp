#include "splash.h"
#include "core/application.h"
#include "core/components/camera.h"

Splash::Splash()
{
};

void Splash::Init()
{
    components.Add(new Camera());
    components.Add(new Sprite("data/splash.png",
                              100.0f,
                              0.0f,
                              1.0f,
                              1.0f));

    timer = Application::GetTime();
};

void Splash::Update()
{
    if (timer->TimeSinceStarted() > 2000)
    {
        Application::NextScene();
    }
};

void Splash::UpdateAfterPhysics()
{
};

