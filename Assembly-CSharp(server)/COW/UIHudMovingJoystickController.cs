using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001915 RID: 6421
	[Token(Token = "0x2001915")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F57BC", Offset = "0x10F57BC")]
	internal class UIHudMovingJoystickController : UIBaseController
	{
		// Token: 0x06008175 RID: 33141 RVA: 0x000233D0 File Offset: 0x000215D0
		[Token(Token = "0x6008175")]
		[Address(RVA = "0x17B4664", Offset = "0x17B4664", VA = "0x7BBBFB4664")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008176 RID: 33142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008176")]
		[Address(RVA = "0x17B46B4", Offset = "0x17B46B4", VA = "0x7BBBFB46B4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008177 RID: 33143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008177")]
		[Address(RVA = "0x17B48D4", Offset = "0x17B48D4", VA = "0x7BBBFB48D4", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06008178 RID: 33144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008178")]
		[Address(RVA = "0x17B4ADC", Offset = "0x17B4ADC", VA = "0x7BBBFB4ADC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008179 RID: 33145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008179")]
		[Address(RVA = "0x17B4BFC", Offset = "0x17B4BFC", VA = "0x7BBBFB4BFC", Slot = "18")]
		protected override void OnUIActiveGroupSwitch(ulong activeGroup)
		{
		}

		// Token: 0x0600817A RID: 33146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600817A")]
		[Address(RVA = "0x17B4CF0", Offset = "0x17B4CF0", VA = "0x7BBBFB4CF0")]
		private void RefreshVisibleWithControlMode(params object[] data)
		{
		}

		// Token: 0x0600817B RID: 33147 RVA: 0x000233E8 File Offset: 0x000215E8
		[Token(Token = "0x600817B")]
		[Address(RVA = "0x17B4F08", Offset = "0x17B4F08", VA = "0x7BBBFB4F08")]
		private bool CheckInSpeedUpCoillder(UserControlAxisData axisData)
		{
			return default(bool);
		}

		// Token: 0x0600817C RID: 33148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600817C")]
		[Address(RVA = "0x17B5250", Offset = "0x17B5250", VA = "0x7BBBFB5250")]
		private void Update()
		{
		}

		// Token: 0x0600817D RID: 33149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600817D")]
		[Address(RVA = "0x17B5CC0", Offset = "0x17B5CC0", VA = "0x7BBBFB5CC0")]
		private void RequestJoyFastRun(bool flag)
		{
		}

		// Token: 0x0600817E RID: 33150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600817E")]
		[Address(RVA = "0x17B5C64", Offset = "0x17B5C64", VA = "0x7BBBFB5C64")]
		private void ActiveJoyStick(bool v)
		{
		}

		// Token: 0x0600817F RID: 33151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600817F")]
		[Address(RVA = "0x17B5E0C", Offset = "0x17B5E0C", VA = "0x7BBBFB5E0C")]
		private void OnLocalPlayerTeamParachuteModeChange(params object[] param)
		{
		}

		// Token: 0x06008180 RID: 33152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008180")]
		[Address(RVA = "0x17B5EFC", Offset = "0x17B5EFC", VA = "0x7BBBFB5EFC")]
		public UIHudMovingJoystickController()
		{
		}

		// Token: 0x0400932A RID: 37674
		[Token(Token = "0x400932A")]
		[FieldOffset(Offset = "0x58")]
		private UIHudMovingJoystickView m_View;

		// Token: 0x0400932B RID: 37675
		[Token(Token = "0x400932B")]
		[FieldOffset(Offset = "0x60")]
		private Vector3 m_DefaultPos;

		// Token: 0x0400932C RID: 37676
		[Token(Token = "0x400932C")]
		[FieldOffset(Offset = "0x6C")]
		private float m_BGRangeRadius;

		// Token: 0x0400932D RID: 37677
		[Token(Token = "0x400932D")]
		[FieldOffset(Offset = "0x70")]
		private UICamera m_UICamera;

		// Token: 0x0400932E RID: 37678
		[Token(Token = "0x400932E")]
		[FieldOffset(Offset = "0x78")]
		private Camera m_Camera;

		// Token: 0x0400932F RID: 37679
		[Token(Token = "0x400932F")]
		[FieldOffset(Offset = "0x80")]
		private float dist;

		// Token: 0x04009330 RID: 37680
		[Token(Token = "0x4009330")]
		[FieldOffset(Offset = "0x84")]
		private bool m_NeedFastRun;

		// Token: 0x04009331 RID: 37681
		[Token(Token = "0x4009331")]
		[FieldOffset(Offset = "0x85")]
		private bool m_IsTouchUp;

		// Token: 0x04009332 RID: 37682
		[Token(Token = "0x4009332")]
		[FieldOffset(Offset = "0x88")]
		private Vector3 m_Position;

		// Token: 0x04009333 RID: 37683
		[Token(Token = "0x4009333")]
		[FieldOffset(Offset = "0x94")]
		private Vector3 m_Rotation;

		// Token: 0x04009334 RID: 37684
		[Token(Token = "0x4009334")]
		[FieldOffset(Offset = "0xA0")]
		private float m_MaxJoyLength;

		// Token: 0x04009335 RID: 37685
		[Token(Token = "0x4009335")]
		[FieldOffset(Offset = "0xA4")]
		private float multiscale;

		// Token: 0x04009336 RID: 37686
		[Token(Token = "0x4009336")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_IsFollowHide;
	}
}
