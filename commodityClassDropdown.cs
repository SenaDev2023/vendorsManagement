var commodityOptions ={
	"PECANS": {
		"Shelled":["Option1","Option2","Option3"],
		"Unshelled": ["OptionA","OptionB","OptionC"]
	
	},

};


//HTML 

<select id="commodityDropdown">
<option value="">Select Commodity</option>
<option value= "PECANS">PECANS</option>

</select>

<select id="commodityOptionDropdown">
	<option value="">Select Option</option>
	</select>
	
	//
	
var commodityOptions ={
	"PECANS": {
		"Shelled":["Option1","Option2","Option3"],
		"Unshelled": ["OptionA","OptionB","OptionC"]
	
	},
	
	//function to update the second dropdown based on the first dropdown	
	function updateCommodityOptions(){
		
		var commodityDropdown = document.getElementById("commodityDropdown");
		var commodityOptionDropdown = document.getElementById("commodityOptionDropdown");
		
		//clear any previous options
		commodityOptionDropdown.innerHTML = '<option value="">Select Option</option>';
		
		//get selected Commodity
		var selectedCommodity = commodityDropdown.value;
		
		//check if te commodity is selected and upate the options
		if(selectedCommodity && commodityOptionDropdown[selectedCommodity])	{
			
			//loop through options for the selected Commodity
			for (var option in commodityOptions[selectedCommodity]){
				//create a new option element for each option 
				var optionElement = document.createElement("option")
				optionElement.value = option;
				optionElement.textcontent = option;
				
				//append the option to the commodity option dropdown
				commodityOptionDropdown.appendChild(optionElement);
				
			}
			
		}};
	
	
	// attach an event listner to the commodity dropdown
	document.getElementById("commodityDropdown").addEventListener("change", function(){
		updateCommodityOptions();
	});
	
	// call the function initally to populate options if needed
	updateCommodityOptions();
