import React from "react";
import Alert from "@mui/material/Alert";


function StatusFailure(props) {

    return (
        <Alert severity="error">{props.validationMessage}</Alert>);
}
export default StatusFailure;