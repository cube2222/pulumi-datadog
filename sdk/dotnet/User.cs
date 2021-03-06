// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Datadog
{
    /// <summary>
    /// Provides a Datadog user resource. This can be used to create and manage Datadog users.
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Datadog = Pulumi.Datadog;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var roRole = Output.Create(Datadog.GetRole.InvokeAsync(new Datadog.GetRoleArgs
    ///         {
    ///             Filter = "Datadog Read Only Role",
    ///         }));
    ///         // Create a new Datadog user
    ///         var foo = new Datadog.User("foo", new Datadog.UserArgs
    ///         {
    ///             Email = "new@example.com",
    ///             Roles = 
    ///             {
    ///                 roRole.Apply(roRole =&gt; roRole.Id),
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// ## Schema
    /// 
    /// ### Required
    /// 
    /// - **email** (String) Email address for user.
    /// 
    /// ### Optional
    /// 
    /// - **access_role** (String, Deprecated) Role description for user. Can be `st` (standard user), `adm` (admin user) or `ro` (read-only user). Default is `st`. `access_role` is ignored for new users created with this resource. New users have to use the `roles` attribute.
    /// - **disabled** (Boolean) Whether the user is disabled.
    /// - **handle** (String, Deprecated) The user handle, must be a valid email.
    /// - **id** (String) The ID of this resource.
    /// - **is_admin** (Boolean, Deprecated) Whether the user is an administrator. Warning: the corresponding query parameter is ignored by the Datadog API, thus the argument would always trigger an execution plan.
    /// - **name** (String) Name for user.
    /// - **role** (String, Deprecated) Role description for user. Warning: the corresponding query parameter is ignored by the Datadog API, thus the argument would always trigger an execution plan.
    /// - **roles** (Set of String) A list a role IDs to assign to the user.
    /// - **send_user_invitation** (Boolean) Whether an invitation email should be sent when the user is created.
    /// 
    /// ### Read-only
    /// 
    /// - **user_invitation_id** (String) The ID of the user invitation that was sent when creating the user.
    /// - **verified** (Boolean) Returns true if Datadog user is verified.
    /// 
    /// ## Import
    /// 
    /// Import is supported using the following syntax
    /// 
    /// ```sh
    ///  $ pulumi import datadog:index/user:User example_user 6f1b44c0-30b2-11eb-86bc-279f7c1ebaa4
    /// ```
    /// </summary>
    [DatadogResourceType("datadog:index/user:User")]
    public partial class User : Pulumi.CustomResource
    {
        /// <summary>
        /// Role description for user. Can be `st` (standard user), `adm` (admin user) or `ro` (read-only user). Default is `st`.
        /// `access_role` is ignored for new users created with this resource. New users have to use the `roles` attribute.
        /// </summary>
        [Output("accessRole")]
        public Output<string?> AccessRole { get; private set; } = null!;

        /// <summary>
        /// Whether the user is disabled.
        /// </summary>
        [Output("disabled")]
        public Output<bool?> Disabled { get; private set; } = null!;

        /// <summary>
        /// Email address for user.
        /// </summary>
        [Output("email")]
        public Output<string> Email { get; private set; } = null!;

        /// <summary>
        /// The user handle, must be a valid email.
        /// </summary>
        [Output("handle")]
        public Output<string?> Handle { get; private set; } = null!;

        /// <summary>
        /// Whether the user is an administrator. Warning: the corresponding query parameter is ignored by the Datadog API, thus the
        /// argument would always trigger an execution plan.
        /// </summary>
        [Output("isAdmin")]
        public Output<bool> IsAdmin { get; private set; } = null!;

        /// <summary>
        /// Name for user.
        /// </summary>
        [Output("name")]
        public Output<string?> Name { get; private set; } = null!;

        /// <summary>
        /// Role description for user. Warning: the corresponding query parameter is ignored by the Datadog API, thus the argument
        /// would always trigger an execution plan.
        /// </summary>
        [Output("role")]
        public Output<string?> Role { get; private set; } = null!;

        /// <summary>
        /// A list a role IDs to assign to the user.
        /// </summary>
        [Output("roles")]
        public Output<ImmutableArray<string>> Roles { get; private set; } = null!;

        /// <summary>
        /// Whether an invitation email should be sent when the user is created.
        /// </summary>
        [Output("sendUserInvitation")]
        public Output<bool?> SendUserInvitation { get; private set; } = null!;

        /// <summary>
        /// The ID of the user invitation that was sent when creating the user.
        /// </summary>
        [Output("userInvitationId")]
        public Output<string> UserInvitationId { get; private set; } = null!;

        /// <summary>
        /// Returns true if Datadog user is verified.
        /// </summary>
        [Output("verified")]
        public Output<bool> Verified { get; private set; } = null!;


        /// <summary>
        /// Create a User resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public User(string name, UserArgs args, CustomResourceOptions? options = null)
            : base("datadog:index/user:User", name, args ?? new UserArgs(), MakeResourceOptions(options, ""))
        {
        }

        private User(string name, Input<string> id, UserState? state = null, CustomResourceOptions? options = null)
            : base("datadog:index/user:User", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing User resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static User Get(string name, Input<string> id, UserState? state = null, CustomResourceOptions? options = null)
        {
            return new User(name, id, state, options);
        }
    }

    public sealed class UserArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Role description for user. Can be `st` (standard user), `adm` (admin user) or `ro` (read-only user). Default is `st`.
        /// `access_role` is ignored for new users created with this resource. New users have to use the `roles` attribute.
        /// </summary>
        [Input("accessRole")]
        public Input<string>? AccessRole { get; set; }

        /// <summary>
        /// Whether the user is disabled.
        /// </summary>
        [Input("disabled")]
        public Input<bool>? Disabled { get; set; }

        /// <summary>
        /// Email address for user.
        /// </summary>
        [Input("email", required: true)]
        public Input<string> Email { get; set; } = null!;

        /// <summary>
        /// The user handle, must be a valid email.
        /// </summary>
        [Input("handle")]
        public Input<string>? Handle { get; set; }

        /// <summary>
        /// Whether the user is an administrator. Warning: the corresponding query parameter is ignored by the Datadog API, thus the
        /// argument would always trigger an execution plan.
        /// </summary>
        [Input("isAdmin")]
        public Input<bool>? IsAdmin { get; set; }

        /// <summary>
        /// Name for user.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Role description for user. Warning: the corresponding query parameter is ignored by the Datadog API, thus the argument
        /// would always trigger an execution plan.
        /// </summary>
        [Input("role")]
        public Input<string>? Role { get; set; }

        [Input("roles")]
        private InputList<string>? _roles;

        /// <summary>
        /// A list a role IDs to assign to the user.
        /// </summary>
        public InputList<string> Roles
        {
            get => _roles ?? (_roles = new InputList<string>());
            set => _roles = value;
        }

        /// <summary>
        /// Whether an invitation email should be sent when the user is created.
        /// </summary>
        [Input("sendUserInvitation")]
        public Input<bool>? SendUserInvitation { get; set; }

        public UserArgs()
        {
        }
    }

    public sealed class UserState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Role description for user. Can be `st` (standard user), `adm` (admin user) or `ro` (read-only user). Default is `st`.
        /// `access_role` is ignored for new users created with this resource. New users have to use the `roles` attribute.
        /// </summary>
        [Input("accessRole")]
        public Input<string>? AccessRole { get; set; }

        /// <summary>
        /// Whether the user is disabled.
        /// </summary>
        [Input("disabled")]
        public Input<bool>? Disabled { get; set; }

        /// <summary>
        /// Email address for user.
        /// </summary>
        [Input("email")]
        public Input<string>? Email { get; set; }

        /// <summary>
        /// The user handle, must be a valid email.
        /// </summary>
        [Input("handle")]
        public Input<string>? Handle { get; set; }

        /// <summary>
        /// Whether the user is an administrator. Warning: the corresponding query parameter is ignored by the Datadog API, thus the
        /// argument would always trigger an execution plan.
        /// </summary>
        [Input("isAdmin")]
        public Input<bool>? IsAdmin { get; set; }

        /// <summary>
        /// Name for user.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Role description for user. Warning: the corresponding query parameter is ignored by the Datadog API, thus the argument
        /// would always trigger an execution plan.
        /// </summary>
        [Input("role")]
        public Input<string>? Role { get; set; }

        [Input("roles")]
        private InputList<string>? _roles;

        /// <summary>
        /// A list a role IDs to assign to the user.
        /// </summary>
        public InputList<string> Roles
        {
            get => _roles ?? (_roles = new InputList<string>());
            set => _roles = value;
        }

        /// <summary>
        /// Whether an invitation email should be sent when the user is created.
        /// </summary>
        [Input("sendUserInvitation")]
        public Input<bool>? SendUserInvitation { get; set; }

        /// <summary>
        /// The ID of the user invitation that was sent when creating the user.
        /// </summary>
        [Input("userInvitationId")]
        public Input<string>? UserInvitationId { get; set; }

        /// <summary>
        /// Returns true if Datadog user is verified.
        /// </summary>
        [Input("verified")]
        public Input<bool>? Verified { get; set; }

        public UserState()
        {
        }
    }
}
