import { MDBContainer, MDBRow } from "mdb-react-ui-kit";
import { AthleteModel } from "../../models/athletes/athlete";
import AthleteListItem from "./athleteListItem";

type Props = {
    athletes: AthleteModel[];
};

function AthleteList({ athletes }: Props) {
    return (
        <MDBContainer>
            <MDBRow className="g-md-3 g-1 row-cols-md-6 row-cols-1">
                {athletes.map((item) => (
                    <AthleteListItem athlete={item} key={item.id} />
                ))}
            </MDBRow>
        </MDBContainer>
    );
}

export default AthleteList;
