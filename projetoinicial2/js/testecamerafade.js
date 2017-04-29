
var game = new Phaser.Game(800, 600, Phaser.CANVAS, 'phaser-example', { preload: preload, create: create, update: update, render: render });

function preload() {

    //game.load.image('background','assets/tests/debug-grid-1920x1920.png');
    game.load.image('background','assets/tests/mapa.png');
    game.load.image('player','assets/sprites/bikkuriman.png');
    game.load.image('player2','assets/sprites/wasp.png');
    game.load.spritesheet('dude', 'assets/dude.png', 32, 48);

}

var player;
var player2;
var cursors;

function create() {

    game.add.tileSprite(0, 0, 1920, 1920, 'background');

    game.world.setBounds(0, 0, 1920, 1920);

    game.physics.startSystem(Phaser.Physics.P2JS);


	player = game.add.sprite(32, game.world.height - 150, 'dude');
	// Determina como será a animação com base nos sprites
	player.animations.add('left', [0, 1, 2, 3], 10, true);
	player.animations.add('right', [5, 6, 7, 8], 10, true);

//    player = game.add.sprite(game.world.centerX, game.world.centerY, 'player');

    game.physics.p2.enable(player);

    player.body.fixedRotation = true;

    cursors = game.input.keyboard.createCursorKeys();

    player2 = game.add.sprite(game.world.centerX, game.world.centerY, 'player2');

    game.physics.p2.enable(player2);

    player2.body.fixedRotation = true;

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

    if (cursors.up.isDown)
    {
        player.body.moveUp(300)
    }
    else if (cursors.down.isDown)
    {
        player.body.moveDown(300);
    }

    if (cursors.left.isDown)
    {
        player.body.moveLeft(300);
	player.animations.play('left');
    }
    else if (cursors.right.isDown)
    {
        player.body.moveRight(300);
	player.animations.play('right');
    } else {
        player.animations.stop();
        player.frame = 4;
    }

}

function render() {

    game.debug.text("Clica aí pra se mecher bundão.", 32, 32);

}
