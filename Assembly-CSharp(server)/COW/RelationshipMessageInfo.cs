using System;
using Il2CppDummyDll;
using proto;
using tcp;

namespace COW
{
	// Token: 0x02001FD8 RID: 8152
	[Token(Token = "0x2001FD8")]
	public class RelationshipMessageInfo
	{
		// Token: 0x17000C44 RID: 3140
		// (get) Token: 0x0600B4F1 RID: 46321 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B4F2 RID: 46322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C44")]
		public FriendAccountInfo SendMsgAccountInfo
		{
			[Token(Token = "0x600B4F1")]
			[Address(RVA = "0x1753E88", Offset = "0x1753E88", VA = "0x7BBBF53E88")]
			get
			{
				return null;
			}
			[Token(Token = "0x600B4F2")]
			[Address(RVA = "0x1753F34", Offset = "0x1753F34", VA = "0x7BBBF53F34")]
			private set
			{
			}
		}

		// Token: 0x0600B4F3 RID: 46323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4F3")]
		[Address(RVA = "0x1753F38", Offset = "0x1753F38", VA = "0x7BBBF53F38", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x0600B4F4 RID: 46324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4F4")]
		[Address(RVA = "0x175402C", Offset = "0x175402C", VA = "0x7BBBF5402C")]
		private void SetMessageCountDown(float validTime, UIRelationshipMsgType msgType)
		{
		}

		// Token: 0x0600B4F5 RID: 46325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4F5")]
		[Address(RVA = "0x1754150", Offset = "0x1754150", VA = "0x7BBBF54150")]
		private void InitMessage()
		{
		}

		// Token: 0x0600B4F6 RID: 46326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4F6")]
		[Address(RVA = "0x17542CC", Offset = "0x17542CC", VA = "0x7BBBF542CC")]
		public void ChangeCurrentMsgType(UIRelationshipMsgType msgType)
		{
		}

		// Token: 0x0600B4F7 RID: 46327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B4F7")]
		[Address(RVA = "0x17543F4", Offset = "0x17543F4", VA = "0x7BBBF543F4")]
		public static implicit operator RelationshipMessageInfo(SepcialFriendsAppsRes appsRes)
		{
			return null;
		}

		// Token: 0x0600B4F8 RID: 46328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B4F8")]
		[Address(RVA = "0x1754528", Offset = "0x1754528", VA = "0x7BBBF54528")]
		public static RelationshipMessageInfo CreateRelationshipMessageInfo(RelatedFriendRequestNtf appsRes, UIRelationshipMsgType msgType)
		{
			return null;
		}

		// Token: 0x0600B4F9 RID: 46329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4F9")]
		[Address(RVA = "0x1754520", Offset = "0x1754520", VA = "0x7BBBF54520")]
		public RelationshipMessageInfo()
		{
		}

		// Token: 0x0400B751 RID: 46929
		[Token(Token = "0x400B751")]
		[FieldOffset(Offset = "0x10")]
		public ulong AccoutID;

		// Token: 0x0400B752 RID: 46930
		[Token(Token = "0x400B752")]
		[FieldOffset(Offset = "0x18")]
		public ulong SendTimeStamp;

		// Token: 0x0400B753 RID: 46931
		[Token(Token = "0x400B753")]
		[FieldOffset(Offset = "0x20")]
		public proto.EFriend.RelationType RelationType;

		// Token: 0x0400B754 RID: 46932
		[Token(Token = "0x400B754")]
		[FieldOffset(Offset = "0x24")]
		public UIRelationshipMsgType MsgType;

		// Token: 0x0400B755 RID: 46933
		[Token(Token = "0x400B755")]
		[FieldOffset(Offset = "0x28")]
		public bool IsRead;

		// Token: 0x0400B756 RID: 46934
		[Token(Token = "0x400B756")]
		[FieldOffset(Offset = "0x2C")]
		private uint m_DelayCall;

		// Token: 0x02001FD9 RID: 8153
		[Token(Token = "0x2001FD9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD604", Offset = "0x10FD604")]
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x0600B4FA RID: 46330 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B4FA")]
			[Address(RVA = "0x1754148", Offset = "0x1754148", VA = "0x7BBBF54148")]
			public <>c__DisplayClass10_0()
			{
			}

			// Token: 0x0600B4FB RID: 46331 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B4FB")]
			[Address(RVA = "0x1754614", Offset = "0x1754614", VA = "0x7BBBF54614")]
			internal void <SetMessageCountDown>b__0()
			{
			}

			// Token: 0x0400B757 RID: 46935
			[Token(Token = "0x400B757")]
			[FieldOffset(Offset = "0x10")]
			public RelationshipMessageInfo <>4__this;

			// Token: 0x0400B758 RID: 46936
			[Token(Token = "0x400B758")]
			[FieldOffset(Offset = "0x18")]
			public UIRelationshipMsgType msgType;
		}
	}
}
