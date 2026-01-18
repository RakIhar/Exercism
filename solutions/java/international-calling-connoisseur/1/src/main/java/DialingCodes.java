import java.util.HashMap;
import java.util.Map;

public class DialingCodes {

    private final HashMap<Integer, String> map = new HashMap<>();

    public Map<Integer, String> getCodes() {
        return Map.copyOf(map);
    }

    public void setDialingCode(Integer code, String country) {
        map.put(code, country);
    }

    public String getCountry(Integer code) {
        return map.get(code);
    }

    public void addNewDialingCode(Integer code, String country) {
        if (!map.containsKey(code) && !map.containsValue(country))
            map.put(code, country);
    }

    public Integer findDialingCode(String country) {
        for (var entry : map.entrySet()) {
            if (entry.getValue().equals(country)) {
                return entry.getKey();
            }
        }
        return null;
    }

    public void updateCountryDialingCode(Integer code, String country) {
        Integer oldCode = findDialingCode(country);
        if (oldCode != null) {
            map.remove(oldCode);
            map.put(code, country);
        }
    }
}
