// 'require' the express module.
const express = require('express')

//instantiate the module
const app = express()

//the absolute path 
const path = require('path')

app.use(express.static('public'))

//PORT
const HTTP_PORT = process.env.PORT || 8080


//ROUTE GET index/home
app.get('/',(req,res)=>{

    //sending a whole html file to client as response.
    res.sendFile(path.join(__dirname,'views/index.html'))

})

//ROUTE GET about
app.get("/about",(req,res)=>{

    //server side console
    console.log("ROUTE GET about")

    //getting & send to client
    res.sendFile(path.join(__dirname,'views/about.html'))
})

//wait for requests
app.listen(8080, () =>{
    console.log("server is lstening on http://localhost:"+HTTP_PORT)
})