using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020019AB RID: 6571
	[Token(Token = "0x20019AB")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F6D1C", Offset = "0x10F6D1C")]
	public class UIHudWolfTaskController : UIBaseController
	{
		// Token: 0x06008696 RID: 34454 RVA: 0x000246C0 File Offset: 0x000228C0
		[Token(Token = "0x6008696")]
		[Address(RVA = "0x1D21854", Offset = "0x1D21854", VA = "0x7BBC521854")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008697 RID: 34455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008697")]
		[Address(RVA = "0x1D218A4", Offset = "0x1D218A4", VA = "0x7BBC5218A4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008698 RID: 34456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008698")]
		[Address(RVA = "0x1D21E38", Offset = "0x1D21E38", VA = "0x7BBC521E38", Slot = "20")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06008699 RID: 34457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008699")]
		[Address(RVA = "0x1D21FAC", Offset = "0x1D21FAC", VA = "0x7BBC521FAC", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x0600869A RID: 34458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600869A")]
		[Address(RVA = "0x1D22330", Offset = "0x1D22330", VA = "0x7BBC522330")]
		private void ToggleButtons()
		{
		}

		// Token: 0x0600869B RID: 34459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600869B")]
		[Address(RVA = "0x1D21B8C", Offset = "0x1D21B8C", VA = "0x7BBC521B8C")]
		private void InitTaskButton(UIButton button, UISprite icon)
		{
		}

		// Token: 0x0600869C RID: 34460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600869C")]
		[Address(RVA = "0x1D22618", Offset = "0x1D22618", VA = "0x7BBC522618")]
		private void OnRoleChange(params object[] data)
		{
		}

		// Token: 0x0600869D RID: 34461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600869D")]
		[Address(RVA = "0x1D2200C", Offset = "0x1D2200C", VA = "0x7BBC52200C")]
		private void OnRefreshWolfTask(params object[] data)
		{
		}

		// Token: 0x0600869E RID: 34462 RVA: 0x000246D8 File Offset: 0x000228D8
		[Token(Token = "0x600869E")]
		[Address(RVA = "0x1D229E4", Offset = "0x1D229E4", VA = "0x7BBC5229E4")]
		private int Cmp(sk~A{Af infoA, sk~A{Af infoB)
		{
			return 0;
		}

		// Token: 0x0600869F RID: 34463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600869F")]
		[Address(RVA = "0x1D22A48", Offset = "0x1D22A48", VA = "0x7BBC522A48")]
		private void OnRefreshSkillCD(params object[] data)
		{
		}

		// Token: 0x060086A0 RID: 34464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086A0")]
		[Address(RVA = "0x1D22B40", Offset = "0x1D22B40", VA = "0x7BBC522B40")]
		private void SetTaskCoolDown(bool value)
		{
		}

		// Token: 0x060086A1 RID: 34465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086A1")]
		[Address(RVA = "0x1D22BFC", Offset = "0x1D22BFC", VA = "0x7BBC522BFC")]
		private void LateUpdate()
		{
		}

		// Token: 0x060086A2 RID: 34466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60086A2")]
		[Address(RVA = "0x1D22D8C", Offset = "0x1D22D8C", VA = "0x7BBC522D8C")]
		public Transform GetAllBtnTransform()
		{
			return null;
		}

		// Token: 0x060086A3 RID: 34467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086A3")]
		[Address(RVA = "0x1D22DCC", Offset = "0x1D22DCC", VA = "0x7BBC522DCC")]
		public UIHudWolfTaskController()
		{
		}

		// Token: 0x04009596 RID: 38294
		[Token(Token = "0x4009596")]
		[FieldOffset(Offset = "0x58")]
		private UIHudWolfTaskView m_View;

		// Token: 0x04009597 RID: 38295
		[Token(Token = "0x4009597")]
		[FieldOffset(Offset = "0x60")]
		private List<UIHudWolfTaskController.WolfTaskButton> m_ButtonList;

		// Token: 0x04009598 RID: 38296
		[Token(Token = "0x4009598")]
		[FieldOffset(Offset = "0x68")]
		private List<sk~A{Af> m_TaskList;

		// Token: 0x04009599 RID: 38297
		[Token(Token = "0x4009599")]
		[FieldOffset(Offset = "0x70")]
		private bool m_ButtonOpen;

		// Token: 0x0400959A RID: 38298
		[Token(Token = "0x400959A")]
		[FieldOffset(Offset = "0x74")]
		private float m_cdTime;

		// Token: 0x0400959B RID: 38299
		[Token(Token = "0x400959B")]
		[FieldOffset(Offset = "0x78")]
		private float m_tarTime;

		// Token: 0x0400959C RID: 38300
		[Token(Token = "0x400959C")]
		[FieldOffset(Offset = "0x7C")]
		private bool m_Dead;

		// Token: 0x020019AC RID: 6572
		[Token(Token = "0x20019AC")]
		private class WolfTaskButton
		{
			// Token: 0x060086A4 RID: 34468 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60086A4")]
			[Address(RVA = "0x1D22E64", Offset = "0x1D22E64", VA = "0x7BBC522E64")]
			public void OnButtonClick()
			{
			}

			// Token: 0x060086A5 RID: 34469 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60086A5")]
			[Address(RVA = "0x1D22890", Offset = "0x1D22890", VA = "0x7BBC522890")]
			public void RefreshIcon()
			{
			}

			// Token: 0x060086A6 RID: 34470 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60086A6")]
			[Address(RVA = "0x1D22610", Offset = "0x1D22610", VA = "0x7BBC522610")]
			public WolfTaskButton()
			{
			}

			// Token: 0x0400959D RID: 38301
			[Token(Token = "0x400959D")]
			[FieldOffset(Offset = "0x10")]
			public UIButton button;

			// Token: 0x0400959E RID: 38302
			[Token(Token = "0x400959E")]
			[FieldOffset(Offset = "0x18")]
			public UISprite icon;

			// Token: 0x0400959F RID: 38303
			[Token(Token = "0x400959F")]
			[FieldOffset(Offset = "0x20")]
			public UITweener[] anim;

			// Token: 0x040095A0 RID: 38304
			[Token(Token = "0x40095A0")]
			[FieldOffset(Offset = "0x28")]
			public sk~A{Af info;
		}
	}
}
