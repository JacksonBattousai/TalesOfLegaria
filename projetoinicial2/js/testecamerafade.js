
var game = new Phaser.Game(800, 600, Phaser.CANVAS, 'phaser-example', { preload: preload, create: create, update: update, render: render });

function preload() {

     game.load.image('background','assets/tests/mapa.png');

    game.load.spritesheet('player','assets/sprites/alex/alex-down.png',32,32,84);
 
}

var player;
var player2;
var cursors;
var facing = '';

function create() {

game.add.tileSprite(0, 0, 1920, 1920, 'background');

    game.world.setBounds(0, 0, 1920, 1920);

    game.physics.startSystem(Phaser.Physics.P2JS);


      player = game.add.sprite(game.world.centerX, game.world.centerY, 'player',1);
      
     
    player.animations.add('down', [1,2,],4, true);
    player.animations.add('left', [13,14,],5, true);
    player.animations.add('up', [36,37,],5, true);
    player.animations.add('right', [25,26,],5, true);
    


    game.physics.p2.enable(player);

    player.body.fixedRotation = true;

    cursors = game.input.keyboard.createCursorKeys();




    cursors = game.input.keyboard.createCursorKeys();

    //  Notice that the sprite doesn't have any momentum at all,
    //  it's all just set by the camera follow type.
    //  0.1 is the amount of linear interpolation to use.
    //  The smaller the value, the smooth the camera (and the longer it takes to catch up)
    game.camera.follow(player, Phaser.Camera.FOLLOW_LOCKON, 0.1, 0.1);

    //  Listen for this signal to reset once the fade is over
    game.camera.onFadeComplete.add(resetFade, this);

    game.input.onDown.add(fade, this);

}

function fade() {

    //  You can set your own fade color and duration
    game.camera.fade(0x000000, 4000);

}

function resetFade() {

    game.camera.resetFX();

}

function update() {

    player.body.setZeroVelocity();



    if (cursors.up.isDown){
        player.body.moveUp(300)

    if (facing != 'up'){ 
           player.animations.play('up');
           facing = 'up';
            }
        }
    else if (cursors.down.isDown){
        player.body.moveDown(300);
        
        if (facing != 'down'){ 
           player.animations.play('down');
           facing = 'down';
            }
    }

    if (cursors.left.isDown){
        player.body.velocity.x = -300;


         if (facing != 'left'){ 
           player.animations.play('left');
           facing = 'left';
            }

    }
    else if (cursors.right.isDown){
        player.body.moveRight(300);
        if (facing != 'right'){ 
           player.animations.play('right');
           facing = 'right';
            }    
    }
    


}
function render() {

    game.debug.text("Beta.", 32, 32);

}
