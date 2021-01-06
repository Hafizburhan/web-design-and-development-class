$(function () {
  $("#myForm").submit(handleFormSubmit);
});

function handleFormSubmit(e) {
  e.preventDefault(); //will stop form event
  $("#exampleInputEmail1").addClass("invalid");
  //   alert("Handle Your code");
}
