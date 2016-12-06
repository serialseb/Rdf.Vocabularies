﻿









// <auto-generated />
using System;

namespace Vocab
{
    /// <summary>The Hydra Core Vocabulary (http://www.w3.org/ns/hydra/core#).</summary>
    public static partial class Hydra
    {
        /// <summary>
        /// hydra
        /// </summary>
        public const string Prefix="hydra";

        /// <summary>
        /// http://www.w3.org/ns/hydra/core#
        /// </summary>
        public const string BaseUri="http://www.w3.org/ns/hydra/core#";

        
        /// <summary>
        /// The class of Hydra classes. Hydra classes and their instances are dereferenceable resources.
        /// </summary>
        public const string Class = BaseUri + "Class";

        
        /// <summary>
        /// A variable-to-property mapping of the IRI template.
        /// </summary>
        public const string mapping = BaseUri + "mapping";

        
        /// <summary>
        /// An IRI template variable
        /// </summary>
        public const string variable = BaseUri + "variable";

        
        /// <summary>
        /// A title, often used along with a description.
        /// </summary>
        public const string title = BaseUri + "title";

        
        /// <summary>
        /// True if the client can change the property's value, false otherwise.
        /// </summary>
        public const string writeable = BaseUri + "writeable";

        
        /// <summary>
        /// A description.
        /// </summary>
        public const string description = BaseUri + "description";

        
        /// <summary>
        /// The HTTP status code
        /// </summary>
        public const string statusCode = BaseUri + "statusCode";

        
        /// <summary>
        /// The HTTP method.
        /// </summary>
        public const string method = BaseUri + "method";

        
        /// <summary>
        /// The total number of items referenced by a collection.
        /// </summary>
        public const string totalItems = BaseUri + "totalItems";

        
        /// <summary>
        /// The representation format to use when expanding the IRI template.
        /// </summary>
        public const string variableRepresentation = BaseUri + "variableRepresentation";

        
        /// <summary>
        /// A property representing a freetext query.
        /// </summary>
        public const string freetextQuery = BaseUri + "freetextQuery";

        
        /// <summary>
        /// A templated string with placeholders. The literal's datatype indicates the template syntax; if not specified, hydra:Rfc6570Template is assumed.
        /// </summary>
        public const string template = BaseUri + "template";

        
        /// <summary>
        /// A property
        /// </summary>
        public const string property = BaseUri + "property";

        
        /// <summary>
        /// True if the client can retrieve the property's value, false otherwise.
        /// </summary>
        public const string readable = BaseUri + "readable";

        
        /// <summary>
        /// True if the property is required, false otherwise.
        /// </summary>
        public const string required = BaseUri + "required";

        
        /// <summary>
        /// A member of the collection
        /// </summary>
        public const string member = BaseUri + "member";

        
        /// <summary>
        /// The resource following the current instance in an interlinked set of resources.
        /// </summary>
        public const string next = BaseUri + "next";

        
        /// <summary>
        /// The resource preceding the current instance in an interlinked set of resources.
        /// </summary>
        public const string previous = BaseUri + "previous";

        
        /// <summary>
        /// The information returned by the Web API on success
        /// </summary>
        public const string returns = BaseUri + "returns";

        
        /// <summary>
        /// The first resource of an interlinked set of resources.
        /// </summary>
        public const string first = BaseUri + "first";

        
        /// <summary>
        /// An operation supported by the Hydra resource
        /// </summary>
        public const string operation = BaseUri + "operation";

        
        /// <summary>
        /// A specific view of a resource.
        /// </summary>
        public const string view = BaseUri + "view";

        
        /// <summary>
        /// An operation supported by instances of the specific Hydra class or the target of the Hydra link
        /// </summary>
        public const string supportedOperation = BaseUri + "supportedOperation";

        
        /// <summary>
        /// A class known to be supported by the Web API
        /// </summary>
        public const string supportedClass = BaseUri + "supportedClass";

        
        /// <summary>
        /// A status that might be returned by the Web API (other statuses should be expected and properly handled as well)
        /// </summary>
        public const string possibleStatus = BaseUri + "possibleStatus";

        
        /// <summary>
        /// The information expected by the Web API.
        /// </summary>
        public const string expects = BaseUri + "expects";

        
        /// <summary>
        /// A link to main entry point of the Web API
        /// </summary>
        public const string entrypoint = BaseUri + "entrypoint";

        
        /// <summary>
        /// The properties known to be supported by a Hydra class
        /// </summary>
        public const string supportedProperty = BaseUri + "supportedProperty";

        
        /// <summary>
        /// The last resource of an interlinked set of resources.
        /// </summary>
        public const string last = BaseUri + "last";

        
        /// <summary>
        /// A link to the API documentation
        /// </summary>
        public const string apiDocumentation = BaseUri + "apiDocumentation";

        /// <summary>
        /// A DeleteResourceOperation is a HTTP operation that deletes a resource.
        /// </summary>
        public const string DeleteResourceOperation = BaseUri + "DeleteResourceOperation";

        /// <summary>
        /// A collection holding references to a number of related resources.
        /// </summary>
        public const string Collection = BaseUri + "Collection";

        /// <summary>
        /// A CreateResourceOperation is a HTTP operation which expects an input of the type specified by hydra:expects and creates a resource of the type specified by hydra:returns.
        /// </summary>
        public const string CreateResourceOperation = BaseUri + "CreateResourceOperation";

        /// <summary>
        /// An operation.
        /// </summary>
        public const string Operation = BaseUri + "Operation";

        /// <summary>
        /// A templated link.
        /// </summary>
        public const string TemplatedLink = BaseUri + "TemplatedLink";

        /// <summary>
        /// The class of IRI templates.
        /// </summary>
        public const string IriTemplate = BaseUri + "IriTemplate";

        /// <summary>
        /// A property known to be supported by a Hydra class.
        /// </summary>
        public const string SupportedProperty = BaseUri + "SupportedProperty";

        /// <summary>
        /// The class of properties representing links.
        /// </summary>
        public const string Link = BaseUri + "Link";

        /// <summary>
        /// The class of dereferenceable resources.
        /// </summary>
        public const string Resource = BaseUri + "Resource";

        /// <summary>
        /// A ReplaceResourceOperation is a HTTP operation which overwrites a resource. It expects data of the type specified in hydra:expects and results in a resource of the type specified by hydra:returns.
        /// </summary>
        public const string ReplaceResourceOperation = BaseUri + "ReplaceResourceOperation";

        /// <summary>
        /// The Hydra API documentation class
        /// </summary>
        public const string ApiDocumentation = BaseUri + "ApiDocumentation";

        /// <summary>
        /// A PartialCollectionView describes a partial view of a Collection. Multiple PartialCollectionViews can be connected with the the next/previous properties to allow a client to retrieve all members of the collection.
        /// </summary>
        public const string PartialCollectionView = BaseUri + "PartialCollectionView";

        /// <summary>
        /// A runtime error, used to report information beyond the returned status code.
        /// </summary>
        public const string Error = BaseUri + "Error";

        /// <summary>
        /// Additional information about a status code that might be returned.
        /// </summary>
        public const string Status = BaseUri + "Status";

        /// <summary>
        /// A mapping from an IRI template variable to a property.
        /// </summary>
        public const string IriTemplateMapping = BaseUri + "IriTemplateMapping";

        /// <summary>
        /// A representation specifies how to serialize variable values into strings.
        /// </summary>
        public const string VariableRepresentation = BaseUri + "VariableRepresentation";

    }
}