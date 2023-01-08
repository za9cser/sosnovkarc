import { faUser } from "@fortawesome/free-solid-svg-icons";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { MDBCol, MDBRow } from "mdb-react-ui-kit";
import { AthleteModel } from "../../models/athletes/athlete";

type Props = {
    athlete: AthleteModel;
};

function AthleteListItem({ athlete }: Props) {
    return (
        <MDBCol center>
            <div className="pt-1 border rounded hover-shadow">
                <MDBRow center>
                    <FontAwesomeIcon icon={faUser} size="10x" className="cursor-text" />
                </MDBRow>
                <MDBRow center>{athlete.lastName}</MDBRow>
                <MDBRow center>{athlete.firstName}</MDBRow>
            </div>
        </MDBCol>
    );
}

export default AthleteListItem;
