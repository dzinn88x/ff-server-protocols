using System;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001FD6 RID: 8150
	[Token(Token = "0x2001FD6")]
	public class RelationshipInfo
	{
		// Token: 0x17000C40 RID: 3136
		// (get) Token: 0x0600B4E0 RID: 46304 RVA: 0x000335B8 File Offset: 0x000317B8
		// (set) Token: 0x0600B4E1 RID: 46305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C40")]
		public EFriend.SpecialFriendState CurrentRelationshipState
		{
			[Token(Token = "0x600B4E0")]
			[Address(RVA = "0x17536F8", Offset = "0x17536F8", VA = "0x7BBBF536F8")]
			get
			{
				return EFriend.SpecialFriendState.SpecialFriendState_NONE;
			}
			[Token(Token = "0x600B4E1")]
			[Address(RVA = "0x1753718", Offset = "0x1753718", VA = "0x7BBBF53718")]
			set
			{
			}
		}

		// Token: 0x17000C41 RID: 3137
		// (get) Token: 0x0600B4E2 RID: 46306 RVA: 0x000335D0 File Offset: 0x000317D0
		// (set) Token: 0x0600B4E3 RID: 46307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C41")]
		public bool Visible
		{
			[Token(Token = "0x600B4E2")]
			[Address(RVA = "0x1753728", Offset = "0x1753728", VA = "0x7BBBF53728")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600B4E3")]
			[Address(RVA = "0x1753748", Offset = "0x1753748", VA = "0x7BBBF53748")]
			set
			{
			}
		}

		// Token: 0x17000C42 RID: 3138
		// (get) Token: 0x0600B4E4 RID: 46308 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B4E5 RID: 46309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C42")]
		public IntimacyState IntimcyState
		{
			[Token(Token = "0x600B4E4")]
			[Address(RVA = "0x1753710", Offset = "0x1753710", VA = "0x7BBBF53710")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146E1C", Offset = "0x1146E1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600B4E5")]
			[Address(RVA = "0x175375C", Offset = "0x175375C", VA = "0x7BBBF5375C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146E2C", Offset = "0x1146E2C")]
			private set
			{
			}
		}

		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x0600B4E6 RID: 46310 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B4E7 RID: 46311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C43")]
		public FriendAccountInfo CurrentTargetFriend
		{
			[Token(Token = "0x600B4E6")]
			[Address(RVA = "0x1753764", Offset = "0x1753764", VA = "0x7BBBF53764")]
			get
			{
				return null;
			}
			[Token(Token = "0x600B4E7")]
			[Address(RVA = "0x175383C", Offset = "0x175383C", VA = "0x7BBBF5383C")]
			private set
			{
			}
		}

		// Token: 0x0600B4E8 RID: 46312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B4E8")]
		[Address(RVA = "0x1753840", Offset = "0x1753840", VA = "0x7BBBF53840")]
		public static RelationshipInfo Createrelationship(IntimacyState state)
		{
			return null;
		}

		// Token: 0x0600B4E9 RID: 46313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4E9")]
		[Address(RVA = "0x1753AD8", Offset = "0x1753AD8", VA = "0x7BBBF53AD8")]
		public void UpdateRelationshipState(EFriend.SpecialFriendState state)
		{
		}

		// Token: 0x0600B4EA RID: 46314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4EA")]
		[Address(RVA = "0x1753AE8", Offset = "0x1753AE8", VA = "0x7BBBF53AE8", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x0600B4EB RID: 46315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4EB")]
		[Address(RVA = "0x1753BDC", Offset = "0x1753BDC", VA = "0x7BBBF53BDC")]
		private void SetStateCountDown(float validTime)
		{
		}

		// Token: 0x0600B4EC RID: 46316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4EC")]
		[Address(RVA = "0x17538E4", Offset = "0x17538E4", VA = "0x7BBBF538E4")]
		private void InitRelationshipState()
		{
		}

		// Token: 0x0600B4ED RID: 46317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4ED")]
		[Address(RVA = "0x17538D4", Offset = "0x17538D4", VA = "0x7BBBF538D4")]
		public RelationshipInfo()
		{
		}

		// Token: 0x0400B74C RID: 46924
		[Token(Token = "0x400B74C")]
		[FieldOffset(Offset = "0x10")]
		public int OldIntimacy;

		// Token: 0x0400B74D RID: 46925
		[Token(Token = "0x400B74D")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11303AC", Offset = "0x11303AC")]
		private IntimacyState <IntimcyState>k__BackingField;

		// Token: 0x0400B74E RID: 46926
		[Token(Token = "0x400B74E")]
		[FieldOffset(Offset = "0x20")]
		private uint m_DelayCall;

		// Token: 0x02001FD7 RID: 8151
		[Token(Token = "0x2001FD7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD5F4", Offset = "0x10FD5F4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600B4EF RID: 46319 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B4EF")]
			[Address(RVA = "0x1753D94", Offset = "0x1753D94", VA = "0x7BBBF53D94")]
			public <>c()
			{
			}

			// Token: 0x0600B4F0 RID: 46320 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B4F0")]
			[Address(RVA = "0x1753D9C", Offset = "0x1753D9C", VA = "0x7BBBF53D9C")]
			internal void <SetStateCountDown>b__18_0()
			{
			}

			// Token: 0x0400B74F RID: 46927
			[Token(Token = "0x400B74F")]
			[FieldOffset(Offset = "0x0")]
			public static readonly RelationshipInfo.<>c <>9;

			// Token: 0x0400B750 RID: 46928
			[Token(Token = "0x400B750")]
			[FieldOffset(Offset = "0x8")]
			public static Action <>9__18_0;
		}
	}
}
