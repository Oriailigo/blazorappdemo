function pagina(){
    return new Promise(() =>{
       


    })  
    }


function search() {
    return new Promise(() =>{
            // Count td if you want to search on all table instead of specific column
          
            var num_cols, display, input, filter, table_body, tr, td, i, txtValue;
			num_cols = 3;
			input = document.getElementById("q");
			filter = input.value.toUpperCase();
			table_body = document.getElementById("the_table_body");
			tr = table_body.getElementsByTagName("tr");

			for(i=0; i< tr.length; i++){				
				display = "none";
				for(j=0; j < num_cols; j++){
					td = tr[i].getElementsByTagName("td")[j];
					if(td){
						txtValue = td.textContent || td.innerText;
						if(txtValue.toUpperCase().indexOf(filter) > -1){
							display = "";
						}
					}
				}
				tr[i].style.display = display;
			}

    })  
    }   
