using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x0200134B RID: 4939
	[Token(Token = "0x200134B")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EB1A8", Offset = "0x10EB1A8")]
	public class ActivityAwardDescription : UIBaseController
	{
		// Token: 0x06004E79 RID: 20089 RVA: 0x00017F70 File Offset: 0x00016170
		[Token(Token = "0x6004E79")]
		[Address(RVA = "0x1F989D8", Offset = "0x1F989D8", VA = "0x7BBC7989D8")]
		public static ResourceID GetVFXResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06004E7A RID: 20090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E7A")]
		[Address(RVA = "0x1F98A28", Offset = "0x1F98A28", VA = "0x7BBC798A28")]
		protected void Start()
		{
		}

		// Token: 0x06004E7B RID: 20091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E7B")]
		[Address(RVA = "0x1F98AD8", Offset = "0x1F98AD8", VA = "0x7BBC798AD8")]
		public void SetData(ClientActivityDesc desc)
		{
		}

		// Token: 0x06004E7C RID: 20092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E7C")]
		[Address(RVA = "0x1F9921C", Offset = "0x1F9921C", VA = "0x7BBC79921C", Slot = "28")]
		protected virtual void SetOperateButtonUI()
		{
		}

		// Token: 0x06004E7D RID: 20093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E7D")]
		[Address(RVA = "0x1F98BC0", Offset = "0x1F98BC0", VA = "0x7BBC798BC0")]
		private void CreateAwards(List<AwardDesc> awards, bool big_prize)
		{
		}

		// Token: 0x06004E7E RID: 20094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E7E")]
		[Address(RVA = "0x1F99C54", Offset = "0x1F99C54", VA = "0x7BBC799C54", Slot = "29")]
		protected virtual void OnOperate()
		{
		}

		// Token: 0x06004E7F RID: 20095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E7F")]
		[Address(RVA = "0x1F99EFC", Offset = "0x1F99EFC", VA = "0x7BBC799EFC")]
		public void Reload()
		{
		}

		// Token: 0x06004E80 RID: 20096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E80")]
		[Address(RVA = "0x1F99F0C", Offset = "0x1F99F0C", VA = "0x7BBC799F0C")]
		public ActivityAwardDescription()
		{
		}

		// Token: 0x0400757B RID: 30075
		[Token(Token = "0x400757B")]
		[FieldOffset(Offset = "0x58")]
		public UIButton OperateButton;

		// Token: 0x0400757C RID: 30076
		[Token(Token = "0x400757C")]
		[FieldOffset(Offset = "0x60")]
		public UISprite OperateWhite;

		// Token: 0x0400757D RID: 30077
		[Token(Token = "0x400757D")]
		[FieldOffset(Offset = "0x68")]
		public UISprite OperateGray;

		// Token: 0x0400757E RID: 30078
		[Token(Token = "0x400757E")]
		[FieldOffset(Offset = "0x70")]
		public UISprite OperateYellow;

		// Token: 0x0400757F RID: 30079
		[Token(Token = "0x400757F")]
		[FieldOffset(Offset = "0x78")]
		public UILabel OperateTitle;

		// Token: 0x04007580 RID: 30080
		[Token(Token = "0x4007580")]
		[FieldOffset(Offset = "0x80")]
		public UILabel Progress;

		// Token: 0x04007581 RID: 30081
		[Token(Token = "0x4007581")]
		[FieldOffset(Offset = "0x88")]
		public UIScrollView AwardScrollView;

		// Token: 0x04007582 RID: 30082
		[Token(Token = "0x4007582")]
		[FieldOffset(Offset = "0x90")]
		public UIGrid AwardGrid;

		// Token: 0x04007583 RID: 30083
		[Token(Token = "0x4007583")]
		[FieldOffset(Offset = "0x98")]
		public GameObject OperateGained;

		// Token: 0x04007584 RID: 30084
		[Token(Token = "0x4007584")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel OperateGainedLabel;

		// Token: 0x04007585 RID: 30085
		[Token(Token = "0x4007585")]
		[FieldOffset(Offset = "0xA8")]
		protected ClientActivityDesc m_Desc;

		// Token: 0x04007586 RID: 30086
		[Token(Token = "0x4007586")]
		[FieldOffset(Offset = "0xB0")]
		private ActivityAwardDescription.OperateStatus m_OperateStatus;

		// Token: 0x04007587 RID: 30087
		[Token(Token = "0x4007587")]
		[FieldOffset(Offset = "0xB8")]
		protected UIModelActivity m_ModelActivity;

		// Token: 0x04007588 RID: 30088
		[Token(Token = "0x4007588")]
		[FieldOffset(Offset = "0xC0")]
		private List<UIStandardItemMiniController> m_CacheAwardList;

		// Token: 0x0200134C RID: 4940
		[Token(Token = "0x200134C")]
		private enum OperateStatus
		{
			// Token: 0x0400758A RID: 30090
			[Token(Token = "0x400758A")]
			None,
			// Token: 0x0400758B RID: 30091
			[Token(Token = "0x400758B")]
			GoTo,
			// Token: 0x0400758C RID: 30092
			[Token(Token = "0x400758C")]
			UnFinished,
			// Token: 0x0400758D RID: 30093
			[Token(Token = "0x400758D")]
			Available,
			// Token: 0x0400758E RID: 30094
			[Token(Token = "0x400758E")]
			Received
		}

		// Token: 0x0200134D RID: 4941
		[Token(Token = "0x200134D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EB1E0", Offset = "0x10EB1E0")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004E82 RID: 20098 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004E82")]
			[Address(RVA = "0x1F99FE0", Offset = "0x1F99FE0", VA = "0x7BBC799FE0")]
			public <>c()
			{
			}

			// Token: 0x06004E83 RID: 20099 RVA: 0x00017F88 File Offset: 0x00016188
			[Token(Token = "0x6004E83")]
			[Address(RVA = "0x1F99FE8", Offset = "0x1F99FE8", VA = "0x7BBC799FE8")]
			internal bool <CreateAwards>b__19_0(AwardDesc e)
			{
				return default(bool);
			}

			// Token: 0x0400758F RID: 30095
			[Token(Token = "0x400758F")]
			[FieldOffset(Offset = "0x0")]
			public static readonly ActivityAwardDescription.<>c <>9;

			// Token: 0x04007590 RID: 30096
			[Token(Token = "0x4007590")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<AwardDesc> <>9__19_0;
		}
	}
}
