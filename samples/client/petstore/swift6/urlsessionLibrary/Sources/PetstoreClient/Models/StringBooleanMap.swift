//
// StringBooleanMap.swift
//
// Generated by openapi-generator
// https://openapi-generator.tech
//

import Foundation

@available(*, deprecated, renamed: "PetstoreClientAPI.StringBooleanMap")
public typealias StringBooleanMap = PetstoreClientAPI.StringBooleanMap

extension PetstoreClientAPI {

public final class StringBooleanMap: @unchecked Sendable, Codable, ParameterConvertible, Hashable {


    public enum CodingKeys: CodingKey, CaseIterable {
    }

    public private(set) var additionalProperties: [String: Bool] = [:]

    public subscript(key: String) -> Bool? {
        get {
            if let value = additionalProperties[key] {
                return value
            }
            return nil
        }

        set {
            additionalProperties[key] = newValue
        }
    }

    // Encodable protocol methods

    public func encode(to encoder: Encoder) throws {
        var container = encoder.container(keyedBy: CodingKeys.self)
        var additionalPropertiesContainer = encoder.container(keyedBy: String.self)
        try additionalPropertiesContainer.encodeMap(additionalProperties)
    }

    // Decodable protocol methods

    public init(from decoder: Decoder) throws {
        let container = try decoder.container(keyedBy: CodingKeys.self)

        var nonAdditionalPropertyKeys = Set<String>()
        let additionalPropertiesContainer = try decoder.container(keyedBy: String.self)
        additionalProperties = try additionalPropertiesContainer.decodeMap(Bool.self, excludedKeys: nonAdditionalPropertyKeys)
    }

    public static func == (lhs: StringBooleanMap, rhs: StringBooleanMap) -> Bool {
        lhs.additionalProperties == rhs.additionalProperties
    }

    public func hash(into hasher: inout Hasher) {
        hasher.combine(additionalProperties.hashValue)
    }
}

}
