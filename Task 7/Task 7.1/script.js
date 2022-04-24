function charRemover(input){
     const separators = Array.of("?", "!", " ", ".", ",", ":",";");
    
    let index = 0;
    for (let i = 0;i<input.length;i++){
        if (!separators.includes(input.charAt(i)) && input.substring(index,i).includes(input.charAt(i))){
            input = input.replaceAll(input.charAt(i),"");
        }
        if (separators.includes(input.charAt(i)))
            index = i;
    }
    return input;
}

console.log(charRemover("У попа была собака"));