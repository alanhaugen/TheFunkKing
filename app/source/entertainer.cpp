#include "entertainer.h"

Entertainer::Entertainer()
{
    tag = "Entertainer";

    appearance = new Sprite("data/entertainer.png", 600.0f, 100.0f, 0.3f, 0.3f);
    description = "A standard clown";
    name = "Clownie";
    skill = 1.0f;
    style = SLAPSTICK;

    clowndance = 0.0f;
    isRejected = false;

    text1 = new Text(name.ToUpperCase(), 300, 150);
    text2 = new Text(description.ToUpperCase(), 600, 200);
    text3 = new Text("STYLE: SLAPSTICK", 600, 250);

    components.Add(appearance);
    components.Add(text1);
    components.Add(text2);
    components.Add(text3);
}

void Entertainer::Hide()
{
    appearance->Hide();

    text1->Hide();
    text2->Hide();
    text3->Hide();

    isRejected = true;
}

void Entertainer::Entertain()
{
    if (isRejected) return;

    appearance->Show();
    text1->Hide();
    text2->Hide();
    text3->Hide();

    appearance->matrix.Translate(glm::vec3(cos(clowndance)*2, sin(clowndance)*2, 0));
    clowndance += 0.4f;
}
