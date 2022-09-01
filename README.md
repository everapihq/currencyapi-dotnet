# currencyapi-dotnet

currencyapi-dotnet is the official C# package for [currencyapi](https://app.currencyapi.com).


## Configuration

You will need your apikey to use currencyapi, you can get one [https://app.currencyapi.com/register](https://app.currencyapi.com/register).

Create an instance and pass your api key like here:

    var fx = new Currencyapi("[YOUR_API_KEY]");

## Usage & Endpoints

Use the instance to call the endpoints

#### Status
Returns your current quota

    fx.status()

#### Currencies
Returns all our supported currencies

    fx.currencies(currencies)

  | Parameter | Data type | Mandatory | Description |
  | --- | ----------- | --- | ----------- |
  | currencies | string | no | A list of comma seperated currency codes which you want to get (EUR,USD,CAD). By default all available currencies will be shown |


#### Latest Exchange Rates
Returns the latest exchange rates. The default base currency is USD.

    fx.latest(base_currency, currencies)    

| Parameter | Data type | Mandatory | Description |
| --- | ----------- | --- | ----------- |
| base_currency | string | no | By default all values are based on USD. By default all values are based on USD |
| currencies | string | no | A list of comma seperated currency codes which you want to get (EUR,USD,CAD). By default all available currencies will be shown |

#### Historical Exchange Rates
Returns the latest exchange rates. The default base currency is USD.

    fx.historical(date, base_currency, currencies)    

| Parameter | Data type | Mandatory | Description |
| --- | ----------- | --- | ----------- |
| date | string | yes | Date to retrieve historical rates from (format: 2021-12-31) |
| base_currency | string | no | By default all values are based on USD. By default all values are based on USD |
| currencies | string | no | A list of comma seperated currency codes which you want to get (EUR,USD,CAD). By default all available currencies will be shown |


#### Range Historical Exchange Rates
Returns a range of exchange rates. Generally, we provide data going back to 1999.

    fx.range(datetime_start, datetime_end, accuracy, baseCurrency, currencies)    

| Parameter | Data type | Mandatory | Description |
| --- | ----------- | --- | ----------- |
| datetime_start | string | yes | Datetime for the start of your requested range (format: 2021-12-31T23:59:59Z / ISO8601 Datetime)
| datetime_end | string | yes | Datetime for the start of your requested range (format: 2021-12-31T23:59:59Z / ISO8601 Datetime) |
| accuracy | string | no | The accuracy you want to receive. Possible Values: day, hour, quarter_hour, minute Default: day For valid time ranges see below |
| base_currency | string | no | By default all values are based on USD. By default all values are based on USD |
| currencies | string | no | A list of comma seperated currency codes which you want to get (EUR,USD,CAD). By default all available currencies will be shown |


#### Convert Exchange Rates
Returns calculated values for today or any given date for all currencies.

    fx.convert(value, date, baseCurrency, currencies)

| Parameter | Data type | Mandatory | Description |
| --- | ----------- | --- | ----------- |
| value | string | yes | The value you want to convert |
| date | string | no | Date to retrieve historical rates from (format: 2021-12-31) |
| base_currency | string | no | By default all values are based on USD. By default all values are based on USD |
| currencies | string | no | A list of comma seperated currency codes which you want to get (EUR,USD,CAD). By default all available currencies will be shown |


You can find further information on https://currencyapi.com/docs/

## Contributing

1. Fork it
2. Create your feature branch (`git checkout -b my-new-feature`)
3. Commit your changes (`git commit -am 'Added some feature'`)
4. Push to the branch (`git push origin my-new-feature`)
5. Create new Pull Request

Bug reports and pull requests are welcome on GitHub at https://github.com/everapihq/currencyapi. This project is intended to be a safe, welcoming space for collaboration, and contributors are expected to adhere to the [code of conduct](https://github.com/everapihq/currencyapi-dotnet//blob/master/CODE_OF_CONDUCT.md).

## License

The gem is available as open source under the terms of the [MIT License](https://opensource.org/licenses/MIT).

## Code of Conduct

Everyone interacting in the Currencyapi project's codebases, issue trackers, chat rooms and mailing lists is expected to follow the [code of conduct](https://github.com/everapihq/currencyapi-dotnet/blob/master/CODE_OF_CONDUCT.md).
