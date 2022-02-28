import React from "react";
import StatusSuccess from "./StatusSuccess";
import StatusFailure from "./StatusFailure";

function StatusIndicator(props) {
    function renderStatus()
    {
        if (props.formState === "success")
        {
            console.log("success state");
            return (<StatusSuccess />);
        }
        if (props.formState === "error")
        {
            console.log("error state");
            return (<StatusFailure />);
        }
        return "";
    }


    return (
        <>
            {renderStatus()}
        </>
    );
}

export default StatusIndicator;