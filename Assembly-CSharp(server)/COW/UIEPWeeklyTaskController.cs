using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200150B RID: 5387
	[Token(Token = "0x200150B")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EDFF4", Offset = "0x10EDFF4")]
	public class UIEPWeeklyTaskController : UIBaseController
	{
		// Token: 0x06005C78 RID: 23672 RVA: 0x0001AEC8 File Offset: 0x000190C8
		[Token(Token = "0x6005C78")]
		[Address(RVA = "0x1AD3B08", Offset = "0x1AD3B08", VA = "0x7BBC2D3B08")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005C79 RID: 23673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C79")]
		[Address(RVA = "0x1AD3B58", Offset = "0x1AD3B58", VA = "0x7BBC2D3B58", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005C7A RID: 23674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C7A")]
		[Address(RVA = "0x1AD3C8C", Offset = "0x1AD3C8C", VA = "0x7BBC2D3C8C", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06005C7B RID: 23675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C7B")]
		[Address(RVA = "0x1AD3D58", Offset = "0x1AD3D58", VA = "0x7BBC2D3D58")]
		private void OnEPQuestUpdate(params object[] data)
		{
		}

		// Token: 0x06005C7C RID: 23676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C7C")]
		[Address(RVA = "0x1AD3C88", Offset = "0x1AD3C88", VA = "0x7BBC2D3C88")]
		private void InitData()
		{
		}

		// Token: 0x06005C7D RID: 23677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C7D")]
		[Address(RVA = "0x1AD3DF8", Offset = "0x1AD3DF8", VA = "0x7BBC2D3DF8")]
		private void RefreshTaskList()
		{
		}

		// Token: 0x06005C7E RID: 23678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C7E")]
		[Address(RVA = "0x1AD43F4", Offset = "0x1AD43F4", VA = "0x7BBC2D43F4")]
		public UIEPWeeklyTaskController()
		{
		}

		// Token: 0x04007EA7 RID: 32423
		[Token(Token = "0x4007EA7")]
		[FieldOffset(Offset = "0x58")]
		private UIEPWeeklyTaskView m_View;

		// Token: 0x04007EA8 RID: 32424
		[Token(Token = "0x4007EA8")]
		[FieldOffset(Offset = "0x60")]
		private List<UIEPWeeklyItemPreviewController> m_TaskItemList;

		// Token: 0x0200150C RID: 5388
		[Token(Token = "0x200150C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EE02C", Offset = "0x10EE02C")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06005C80 RID: 23680 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005C80")]
			[Address(RVA = "0x1AD44C8", Offset = "0x1AD44C8", VA = "0x7BBC2D44C8")]
			public <>c()
			{
			}

			// Token: 0x06005C81 RID: 23681 RVA: 0x0001AEE0 File Offset: 0x000190E0
			[Token(Token = "0x6005C81")]
			[Address(RVA = "0x1AD44D0", Offset = "0x1AD44D0", VA = "0x7BBC2D44D0")]
			internal int <RefreshTaskList>b__7_0(EPWeeklyQuestGroupData a, EPWeeklyQuestGroupData b)
			{
				return 0;
			}

			// Token: 0x04007EA9 RID: 32425
			[Token(Token = "0x4007EA9")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIEPWeeklyTaskController.<>c <>9;

			// Token: 0x04007EAA RID: 32426
			[Token(Token = "0x4007EAA")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<EPWeeklyQuestGroupData> <>9__7_0;
		}
	}
}
