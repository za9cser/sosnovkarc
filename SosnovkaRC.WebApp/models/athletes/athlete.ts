export type AthleteModel = {
    id: number;
    firstName: string;
    lastName: string;
};

export type AthletesModel = {
    athletes: AthleteModel[];
};
