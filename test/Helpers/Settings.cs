using System;

namespace SWSDK.Test.Helpers
{
    static class Settings
    {
        public const string 
            Token = "temporaly unavailable",
            Url = "https://api.sw.com.mx",
            RFC = "FUNK671228PH6",
            Cer = "MIIF0TCCA7mgAwIBAgIUMzAwMDEwMDAwMDA0MDAwMDIzMDIwDQYJKoZIhvcNAQELBQAwggErMQ8wDQYDVQQDDAZBQyBVQVQxLjAsBgNVBAoMJVNFUlZJQ0lPIERFIEFETUlOSVNUUkFDSU9OIFRSSUJVVEFSSUExGjAYBgNVBAsMEVNBVC1JRVMgQXV0aG9yaXR5MSgwJgYJKoZIhvcNAQkBFhlvc2Nhci5tYXJ0aW5lekBzYXQuZ29iLm14MR0wGwYDVQQJDBQzcmEgY2VycmFkYSBkZSBjYWRpejEOMAwGA1UEEQwFMDYzNzAxCzAJBgNVBAYTAk1YMRkwFwYDVQQIDBBDSVVEQUQgREUgTUVYSUNPMREwDwYDVQQHDAhDT1lPQUNBTjERMA8GA1UELRMIMi41LjQuNDUxJTAjBgkqhkiG9w0BCQITFnJlc3BvbnNhYmxlOiBBQ0RNQS1TQVQwHhcNMTkwNTI4MjE1MTA1WhcNMjMwNTI3MjE1MTA1WjCBxjEdMBsGA1UEAxMUS0FSTEEgRlVFTlRFIE5PTEFTQ08xHTAbBgNVBCkTFEtBUkxBIEZVRU5URSBOT0xBU0NPMR0wGwYDVQQKExRLQVJMQSBGVUVOVEUgTk9MQVNDTzELMAkGA1UEBhMCTVgxJTAjBgkqhkiG9w0BCQEWFnBydWViYXNAcHJ1ZWJhcy5nb2IubXgxFjAUBgNVBC0TDUZVTks2NzEyMjhQSDYxGzAZBgNVBAUTEkZVTks2NzEyMjhNQ0xOTFIwNTCCASIwDQYJKoZIhvcNAQEBBQADggEPADCCAQoCggEBAJ2l/8KWpWaA1nZwitay0NS+1fwei8MBpc2pTSQyS4M9HU+tIDB9GckSV147bykNlymLjU3x1IGd4YNKC9IH6Mdi+nOfxwPsDZhjWIkVEUm/D/r56I1xxvdpl2a8t7rYSoMMSZcu595tLG6PTguuUhWlti9UF0DLLpiMJT1p5Ipez3LP5rZpo0ZNtAZEbnDffR4uNt3uGvkgbta9l2JOpszJclnspEpI0+soV4NNuUWIE0SS1ZV2pyjnsqJXl57v5CXVCmTqPTOz+k0IbmF/k/zRamEbYGfrcj6FGxOtUAKH9egogEyaw7D3R2jQW8c4/xq4btidlCcIr2Ft95HDGi0CAwEAAaNPME0wDAYDVR0TAQH/BAIwADALBgNVHQ8EBAMCA9gwEQYJYIZIAYb4QgEBBAQDAgWgMB0GA1UdJQQWMBQGCCsGAQUFBwMEBggrBgEFBQcDAjANBgkqhkiG9w0BAQsFAAOCAgEAkqz5HjsIbSIv/vb/alYlHw7DC7NZ5uajBjsPJng6nW3eDRzv7tX9ajnC8cGVCqT3QME0jRxSpvnbZbjsbeWGO9R/6ncLuFhI8hVfAQrGXicODjUZ3hWMuQpRbmr0kjwM+sncsBY1jOsM69tiIH22pknBdXfdc06bzgweu3rEqneKcWN04vLP+58wUNx16HnnURbHasV19nsNqT7alns5f98BjOCBAqEXXMCPuJubC4jmYUmHMFt0rTeTWZn1GvwFDwjhEc9p0fQtP17gg8IYcT2qScIXtVXWRdNVAJ96nQqrCftfwtf2EyAcH+Q59bs2yd+8xNv0Q2lai962AWjg1hnRmBOS3tTHlPrqr/6jeXmiUpPJs6mJG0WEOEWkbe/LgBo67XIoKY5G+eEjtCRqxRedgZEcbn7834yBPUsjdfhybrpSVv4NJre6e64/xr+vowzfjHATuizB2aRbVRzRxRLC+b2XTRl/tm8gVZeMWKHPAK/LsREnTieaq02NdhWPHnWpfiYj27AnkQh/R24MsUrSyDSQDiyAJR6Lxe36Gu0hwCsdE9q9YsbrUiCX03EaMT0r7frRLjw23FC86qPOdtUDS46gDE9QioiUF9ecoDYRwvgWqXxvTnIj64YqEjBUubjMiacoDVAZLmlxYL0QrBcXtgansw+nO9coLIRX+oo=",
            Key = "MIIFDjBABgkqhkiG9w0BBQ0wMzAbBgkqhkiG9w0BBQwwDgQIAgEAAoIBAQACAggAMBQGCCqGSIb3DQMHBAgwggS9AgEAMASCBMh4EHl7aNSCaMDA1VlRoXCZ5UUmqErAbucRBAKNQXH8t40tSJdbQvHJaI0ttKlZyVIqZDrrmujcBOJg+AwsxLlJSwOJYR1kljSp0vkuKbeM2739iPVCeefZOrjlNxjXbOOApllfYKELvC7ewhejG/085sCpM8/ahAaXGWvAk83IOUuL5dBZ/A6NmYGqpdR6irmyCNlzBVHGSz/I5UUR4Dc2iLQKqdlphYIW1aA8bYqC5A+QIXgdFIj0CNVCGq11yeFTNAHQgfxviZvObBmCfv6QHAgC0XLD2IpaAPcU9oC9PQYrQjT2Ffy3yZf4uhSMsCvFB9RbrAopJuEOe8XHHN6KBUvjJXYis3NKW5KpAst+d5aw3KCIVVhlmAPSQIl9aQvQwIOu84pPm/Ab24CZfPgfskwoSB8QySVCa6g2SYbeFfQai5TrN0icnpgpD6KFo2jrGbUlPH5xFFN7VXbSeesH+b9Kbj3ZtT5GkNQS9TM51HGseeLzbmcHHLdL8C7Nml6JbFNSKEKH+yNbXv2p452lP0rChBBSG1oSiM3ooj+lq64IJHP96GFtzjVI/BhWvwdbur2N/H+4tS1HHhT+F11ybPL/4hc7vyh1VwSZZ8SusD67kM48iaGkuYELnE2Mw4WEhTW7OPjbkLw4rPzE5TxXJNylaGQLP5n1/KKWVif/K14fH7uW/Twftzp4bJzGimfVYJgcGIVsmQDDgkPNYQnbDyy9T2MGlgqsmljSdHlpMoei29JQG0CUBTF5E1ZctqymIxn9msm48a18EOyc/14pJeJu1QEh8TSilPfpleHjocHP6PiuRX/4BOx3eZKCyWIknSTXZgvg/mxf6rTClhrMCdOxP/gQHtd+iDRdWcgtIfwLu+eW7jTLwEQq0RA0axtfoqLg8avAPHqxdl360FnkRKsM00zAFXP6zEIG7ON3qSkNaIWjADlOtqm1MkpMKUfIPcOoENEHIBDJy9U4ushLS8i34zApHyWx8bX6NeJA0L7I18fO2J09tTvNDtX/zLQgzqrGc3B41XVc+hMkyEBYbujQEzt46CswRnCvIa4mkSYgzU/O7xNOd+gMh+2GwmkJj5VuapAGNtvzsg4KCR7X2qqniSp5gUfokkS9OTVNZyksY/Xl+6GKLSkRe8a5vZDpKi7STucNfjFoesQc2zHji46vg/pXtvL7b2EMNuCTdHaWwi+aCEVJWSW+gCOjMhhmYb5WvVXyYdFegc7eLbfBgiMFmUVQ7CqdYxKErT6McdDjMKj1D5HZyKHqcb2Tynnl+pIh8DrQ5YWPtwWGoDQHS8OAcxzbb/ScPVZHQSJCc9jRkbE+30VTtXopwV7hQUrtJNz6wi6hqvdi9qk1wmS26xglFO7u/zFniOFXx+w+tWoU5UWtJHbH0dwuxz/CSHq/1BngjvFNOLKFK6fXexRx4tcJ8rDM39s4azATeLvstiwUL+SdE98545JQ2OI1QyCehlHQVpZXtCfYvG8ELZ1oJunqZ9PgKD/Il11ZOPjudI89QvSK39EyFZERWm+kdCnzwHSRmG9VX+tgGj9LPu13DpXU/LRIRCIkZEN6Geg5bg6ftFL2TJmbqd3vB8D4GPSf3P/6VY4KAArKJa+afWpCgLdl6RhQ92s=",
            Pass= "12345678a";
    }
}
