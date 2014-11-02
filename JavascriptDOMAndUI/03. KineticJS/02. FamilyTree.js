// Todally no idea why the lines didn't get any curves despite the tention attribute.
// I'd be really gratefull if you could point me the reason.

document.addEventListener("DOMContentLoaded", function (event) {

    var familyMembers = [{
        mother: 'Maria Petrova',
        father: 'Georgi Petrov',
        children: ['Teodora Petrova',
        'Peter Petrov']
    }, {
        mother: 'Petra Stamatova',
        father: 'Todor Stamatov',
        children: ['Maria Petrova']
    }],

    stage = new Kinetic.Stage({
        container: 'kinetic-container',
        width: 600,
        height: 400
    }),
    layer = new Kinetic.Layer(),
    maleRect = new Kinetic.Rect({
        x: 10,
        y: 10,
        width: 150,
        height: 40,
        stroke: 'green',
        strokeWidth: 2,
        cornerRadius: 10
    }),
    femaleRect = new Kinetic.Rect({
        x: 10,
        y: 10,
        width: 150,
        height: 40,
        stroke: 'green',
        strokeWidth: 2,
        cornerRadius: 20
    }),
    text = new Kinetic.Text({
        x: 22,
        y: 22,
        text: 'Simple Text',
        fontSize: 16,
        fontFamily: 'Arial',
        fill: 'black'
    }),
    arrow = new Kinetic.Line({
        points: [0, 0, 0, 0],
        stroke: 'green',
        strokeWidth: 2,
        tension: 1
    });

    grandfatherBox = maleRect.clone();
    grandfatherBox.setX(160);
    grandfatherName = text.clone();
    grandfatherName.setText(familyMembers[1].father);
    grandfatherName.setX(grandfatherBox.getPosition().x + (150 - grandfatherName.getWidth()) / 2);

    layer.add(grandfatherBox);
    layer.add(grandfatherName);


    grandmotherBox = femaleRect.clone();
    grandmotherBox.setX(350);
    grandmotherName = text.clone();
    grandmotherName.setText(familyMembers[1].mother);
    grandmotherName.setX(grandmotherBox.getPosition().x + (150 - grandmotherName.getWidth()) / 2);
    layer.add(grandmotherBox);
    layer.add(grandmotherName);

    fatherBox = maleRect.clone();
    fatherBox.setX(10);
    fatherBox.setY(100);
    fatherName = text.clone();
    fatherName.setText(familyMembers[0].father);
    fatherName.setX(fatherBox.getPosition().x + (150 - fatherName.getWidth()) / 2);
    fatherName.setY(fatherBox.getPosition().y + 12);
    layer.add(fatherBox);
    layer.add(fatherName);

    motherBox = femaleRect.clone();
    motherBox.setX(250);
    motherBox.setY(100)
    motherName = text.clone();
    motherName.setText(familyMembers[0].mother);
    motherName.setX(motherBox.getPosition().x + (150 - motherName.getWidth()) / 2);
    motherName.setY(motherBox.getPosition().y + 12)
    layer.add(motherBox);
    layer.add(motherName);

    sonBox = maleRect.clone();
    sonBox.setX(160);
    sonBox.setY(200);
    sonName = text.clone();
    sonName.setText(familyMembers[0].children[1]);
    sonName.setX(sonBox.getPosition().x + (150 - sonName.getWidth()) / 2);
    sonName.setY(sonBox.getPosition().y + 12);
    layer.add(sonBox);
    layer.add(sonName);

    daughterBox = femaleRect.clone();
    daughterBox.setX(350);
    daughterBox.setY(200)
    daughterName = text.clone();
    daughterName.setText(familyMembers[0].children[0]);
    daughterName.setX(daughterBox.getPosition().x + (150 - daughterName.getWidth()) / 2);
    daughterName.setY(daughterBox.getPosition().y + 12)
    layer.add(daughterBox);
    layer.add(daughterName);

    newArrow = arrow.clone();
    newArrow.setPoints([grandfatherBox.getPosition().x * 1.5, grandfatherBox.getPosition().y + 40, motherBox.getPosition().x * 1.3, motherBox.getPosition().y]);
    layer.add(newArrow);

    newArrow = arrow.clone();
    newArrow.setPoints([grandmotherBox.getPosition().x * 1.25, grandmotherBox.getPosition().y + 40, motherBox.getPosition().x * 1.3, motherBox.getPosition().y]);
    layer.add(newArrow);

    newArrow = arrow.clone();
    newArrow.setPoints([80, fatherBox.getPosition().y + 40, sonBox.getPosition().x * 1.5, sonBox.getPosition().y]);
    layer.add(newArrow);

    newArrow = arrow.clone();
    newArrow.setPoints([motherBox.getPosition().x * 1.3, motherBox.getPosition().y + 40, sonBox.getPosition().x * 1.5, sonBox.getPosition().y]);
    layer.add(newArrow);

    newArrow = arrow.clone();
    newArrow.setPoints([motherBox.getPosition().x * 1.3, motherBox.getPosition().y + 40, daughterBox.getPosition().x * 1.22, daughterBox.getPosition().y]);
    layer.add(newArrow);

    stage.add(layer);

});