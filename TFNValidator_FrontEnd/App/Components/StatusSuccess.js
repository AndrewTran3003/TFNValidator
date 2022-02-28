import React from "react";
import Alert from "@mui/material/Alert";


function StatusSuccess(props) {
    return (
        <Alert severity="success">{props.validationMessage}</Alert>);
}
export default StatusSuccess;