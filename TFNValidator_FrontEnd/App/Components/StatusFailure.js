import React, {useState} from "react";
import Alert from "@mui/material/Alert";


function StatusFailure() {
    const [display, setDisplay] = useState("none");
    const style = {
        display: display
    }
    return (
        <Alert sx={style} severity="error">This is an error alert — check it out!</Alert>);
}
export default StatusFailure;