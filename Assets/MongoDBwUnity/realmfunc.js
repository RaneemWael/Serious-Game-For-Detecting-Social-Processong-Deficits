//Send Stuff
//https://webhooks.mongodb-realm.com/api/client/v2.0/app/serious-game-social-deficits-zziwh/service/SeriousGameData/incoming_webhook/webhook0

exports = async function(payload, response) {

    console.log("Adding Info...");
    const path = context.services.get("mongodb-atlas").db("SeriousGameData").collection("PlayerData");

    // parse the body to get the tag
    const info = EJSON.parse(payload.body.text());

    return path.insertOne(info);

};
