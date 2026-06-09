using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002332 RID: 9010
	[Token(Token = "0x2002332")]
	public class UIHudPreparationTimerView : UIBaseView
	{
		// Token: 0x0600C174 RID: 49524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C174")]
		[Address(RVA = "0x17DFD68", Offset = "0x17DFD68", VA = "0x7BBBFDFD68", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C175 RID: 49525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C175")]
		[Address(RVA = "0x17DFECC", Offset = "0x17DFECC", VA = "0x7BBBFDFECC")]
		public UIHudPreparationTimerView()
		{
		}

		// Token: 0x0400DA80 RID: 55936
		[Token(Token = "0x400DA80")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Alien_Skill;

		// Token: 0x0400DA81 RID: 55937
		[Token(Token = "0x400DA81")]
		[FieldOffset(Offset = "0x28")]
		public UISprite content;

		// Token: 0x0400DA82 RID: 55938
		[Token(Token = "0x400DA82")]
		[FieldOffset(Offset = "0x30")]
		public UISprite Progress;

		// Token: 0x0400DA83 RID: 55939
		[Token(Token = "0x400DA83")]
		[FieldOffset(Offset = "0x38")]
		public UILabel TimeLabel;
	}
}
