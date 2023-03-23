 
function confirmar(){
    return new Promise(resolve =>{
        Swal.fire(
            'The Internet?',
            'That thing is still around?',
            'question'
        ).then((result)=>{
            resolve(result.isConfirmed);
        
        })    
    })   
    
}