using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001951 RID: 6481
	[Token(Token = "0x2001951")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F5FB4", Offset = "0x10F5FB4")]
	public class UIHudRevivePointPosMarkController : UIHudNameBaseController
	{
		// Token: 0x06008387 RID: 33671 RVA: 0x00023B68 File Offset: 0x00021D68
		[Token(Token = "0x6008387")]
		[Address(RVA = "0x17F94B0", Offset = "0x17F94B0", VA = "0x7BBBFF94B0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008388 RID: 33672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008388")]
		[Address(RVA = "0x17F9500", Offset = "0x17F9500", VA = "0x7BBBFF9500", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008389 RID: 33673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008389")]
		[Address(RVA = "0x17F9804", Offset = "0x17F9804", VA = "0x7BBBFF9804", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x0600838A RID: 33674 RVA: 0x00023B80 File Offset: 0x00021D80
		[Token(Token = "0x600838A")]
		[Address(RVA = "0x17F9964", Offset = "0x17F9964", VA = "0x7BBBFF9964", Slot = "28")]
		protected override Vector3 TargetPosition()
		{
			return default(Vector3);
		}

		// Token: 0x0600838B RID: 33675 RVA: 0x00023B98 File Offset: 0x00021D98
		[Token(Token = "0x600838B")]
		[Address(RVA = "0x17F9A0C", Offset = "0x17F9A0C", VA = "0x7BBBFF9A0C", Slot = "30")]
		protected override bool NeedKeepInScreen()
		{
			return default(bool);
		}

		// Token: 0x0600838C RID: 33676 RVA: 0x00023BB0 File Offset: 0x00021DB0
		[Token(Token = "0x600838C")]
		[Address(RVA = "0x17F9A14", Offset = "0x17F9A14", VA = "0x7BBBFF9A14", Slot = "37")]
		protected override Vector2 GetWidgetBound()
		{
			return default(Vector2);
		}

		// Token: 0x0600838D RID: 33677 RVA: 0x00023BC8 File Offset: 0x00021DC8
		[Token(Token = "0x600838D")]
		[Address(RVA = "0x17F9A84", Offset = "0x17F9A84", VA = "0x7BBBFF9A84", Slot = "32")]
		protected override bool NeedShowDistance()
		{
			return default(bool);
		}

		// Token: 0x0600838E RID: 33678 RVA: 0x00023BE0 File Offset: 0x00021DE0
		[Token(Token = "0x600838E")]
		[Address(RVA = "0x17F9A8C", Offset = "0x17F9A8C", VA = "0x7BBBFF9A8C", Slot = "31")]
		protected override bool NeedUpdatePosition()
		{
			return default(bool);
		}

		// Token: 0x0600838F RID: 33679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600838F")]
		[Address(RVA = "0x17F9A94", Offset = "0x17F9A94", VA = "0x7BBBFF9A94")]
		public void BindTarget(uint id, Vector3 target)
		{
		}

		// Token: 0x06008390 RID: 33680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008390")]
		[Address(RVA = "0x17F9AA4", Offset = "0x17F9AA4", VA = "0x7BBBFF9AA4")]
		public void Reset()
		{
		}

		// Token: 0x06008391 RID: 33681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008391")]
		[Address(RVA = "0x17F9B28", Offset = "0x17F9B28", VA = "0x7BBBFF9B28")]
		public void SetState(HtHW[yY state)
		{
		}

		// Token: 0x06008392 RID: 33682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008392")]
		[Address(RVA = "0x17FA194", Offset = "0x17FA194", VA = "0x7BBBFFA194")]
		public void SetTime(int time)
		{
		}

		// Token: 0x06008393 RID: 33683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008393")]
		[Address(RVA = "0x17FA380", Offset = "0x17FA380", VA = "0x7BBBFFA380")]
		private void Update()
		{
		}

		// Token: 0x06008394 RID: 33684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008394")]
		[Address(RVA = "0x17FA3B0", Offset = "0x17FA3B0", VA = "0x7BBBFFA3B0", Slot = "33")]
		protected override void OnDistanceChanged(float distance)
		{
		}

		// Token: 0x06008395 RID: 33685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008395")]
		[Address(RVA = "0x17FA49C", Offset = "0x17FA49C", VA = "0x7BBBFFA49C")]
		private void OnEnterRevivePoint(params object[] data)
		{
		}

		// Token: 0x06008396 RID: 33686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008396")]
		[Address(RVA = "0x17FA78C", Offset = "0x17FA78C", VA = "0x7BBBFFA78C")]
		private void OnLocalPlayerDead(params object[] data)
		{
		}

		// Token: 0x06008397 RID: 33687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008397")]
		[Address(RVA = "0x17FA89C", Offset = "0x17FA89C", VA = "0x7BBBFFA89C")]
		public UIHudRevivePointPosMarkController()
		{
		}

		// Token: 0x0400944D RID: 37965
		[Token(Token = "0x400944D")]
		[FieldOffset(Offset = "0xA8")]
		private UIHudRevivePointPosMarkView m_View;

		// Token: 0x0400944E RID: 37966
		[Token(Token = "0x400944E")]
		[FieldOffset(Offset = "0xB0")]
		private uint m_RevivePointId;

		// Token: 0x0400944F RID: 37967
		[Token(Token = "0x400944F")]
		[FieldOffset(Offset = "0xB4")]
		private Vector3 m_RevivePointPos;

		// Token: 0x04009450 RID: 37968
		[Token(Token = "0x4009450")]
		[FieldOffset(Offset = "0xC0")]
		private HtHW[yY m_CurrentState;

		// Token: 0x04009451 RID: 37969
		[Token(Token = "0x4009451")]
		[FieldOffset(Offset = "0xC8")]
		private UIModelMatch m_ModelMatch;

		// Token: 0x04009452 RID: 37970
		[Token(Token = "0x4009452")]
		[FieldOffset(Offset = "0xD0")]
		private int m_RevivePointMarkShowDis;

		// Token: 0x04009453 RID: 37971
		[Token(Token = "0x4009453")]
		[FieldOffset(Offset = "0xD4")]
		private bool m_NeedUpdatePosition;

		// Token: 0x04009454 RID: 37972
		[Token(Token = "0x4009454")]
		[FieldOffset(Offset = "0x0")]
		public static Color ReviveIconNormal;

		// Token: 0x04009455 RID: 37973
		[Token(Token = "0x4009455")]
		[FieldOffset(Offset = "0x10")]
		public static Color ReviveBgNormal;

		// Token: 0x04009456 RID: 37974
		[Token(Token = "0x4009456")]
		[FieldOffset(Offset = "0x20")]
		public static Color ReviveIconCD;

		// Token: 0x04009457 RID: 37975
		[Token(Token = "0x4009457")]
		[FieldOffset(Offset = "0x30")]
		public static Color ReviveBgCD;

		// Token: 0x04009458 RID: 37976
		[Token(Token = "0x4009458")]
		[FieldOffset(Offset = "0xD8")]
		private UITimeLabelHelper m_TimeHelper;
	}
}
