using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002132 RID: 8498
	[Token(Token = "0x2002132")]
	public class UIChampionshipLobbyView : UIBaseView
	{
		// Token: 0x0600BD74 RID: 48500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD74")]
		[Address(RVA = "0x1EC5664", Offset = "0x1EC5664", VA = "0x7BBC6C5664", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD75 RID: 48501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD75")]
		[Address(RVA = "0x1EC5784", Offset = "0x1EC5784", VA = "0x7BBC6C5784")]
		public UIChampionshipLobbyView()
		{
		}

		// Token: 0x0400C38F RID: 50063
		[Token(Token = "0x400C38F")]
		[FieldOffset(Offset = "0x20")]
		public UIButton RuleBtn;

		// Token: 0x0400C390 RID: 50064
		[Token(Token = "0x400C390")]
		[FieldOffset(Offset = "0x28")]
		public Animation Animation;

		// Token: 0x0400C391 RID: 50065
		[Token(Token = "0x400C391")]
		[FieldOffset(Offset = "0x30")]
		public GameObject EntranceContainer;
	}
}
