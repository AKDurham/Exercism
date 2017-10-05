module SpaceAge

type Planet = Earth | Mercury | Venus | Mars | Jupiter | Saturn | Uranus | Neptune

let earthOrbitalPeriod = 31557600m;

let spaceAge (planet: Planet) (seconds: decimal): decimal = 
    let planetaryYear = match planet with
        | Earth -> earthOrbitalPeriod
        | Mercury -> earthOrbitalPeriod * 0.2408467m
        | Venus -> earthOrbitalPeriod * 0.61519726m
        | Mars -> earthOrbitalPeriod * 1.8808158m
        | Jupiter -> earthOrbitalPeriod * 11.862615m
        | Saturn -> earthOrbitalPeriod * 29.447498m
        | Uranus -> earthOrbitalPeriod * 84.016846m
        | Neptune -> earthOrbitalPeriod * 164.79132m

    let precisePlanetaryAge = seconds / planetaryYear
    System.Decimal.Round(precisePlanetaryAge, 2)