using System;
using System.Text;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001918 RID: 6424
	[Token(Token = "0x2001918")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F582C", Offset = "0x10F582C")]
	public class UIHudNameBaseController : UIBaseController
	{
		// Token: 0x0600818C RID: 33164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600818C")]
		[Address(RVA = "0x17B6100", Offset = "0x17B6100", VA = "0x7BBBFB6100", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x0600818D RID: 33165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600818D")]
		[Address(RVA = "0x17B6220", Offset = "0x17B6220", VA = "0x7BBBFB6220", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600818E RID: 33166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600818E")]
		[Address(RVA = "0x17B62EC", Offset = "0x17B62EC", VA = "0x7BBBFB62EC", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x0600818F RID: 33167 RVA: 0x00023418 File Offset: 0x00021618
		[Token(Token = "0x600818F")]
		[Address(RVA = "0x17B63B8", Offset = "0x17B63B8", VA = "0x7BBBFB63B8", Slot = "28")]
		protected virtual Vector3 TargetPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06008190 RID: 33168 RVA: 0x00023430 File Offset: 0x00021630
		[Token(Token = "0x6008190")]
		[Address(RVA = "0x17B6418", Offset = "0x17B6418", VA = "0x7BBBFB6418", Slot = "29")]
		protected virtual bool NeedAutoScaleByDistance()
		{
			return default(bool);
		}

		// Token: 0x06008191 RID: 33169 RVA: 0x00023448 File Offset: 0x00021648
		[Token(Token = "0x6008191")]
		[Address(RVA = "0x17B6420", Offset = "0x17B6420", VA = "0x7BBBFB6420", Slot = "30")]
		protected virtual bool NeedKeepInScreen()
		{
			return default(bool);
		}

		// Token: 0x06008192 RID: 33170 RVA: 0x00023460 File Offset: 0x00021660
		[Token(Token = "0x6008192")]
		[Address(RVA = "0x17B6428", Offset = "0x17B6428", VA = "0x7BBBFB6428", Slot = "31")]
		protected virtual bool NeedUpdatePosition()
		{
			return default(bool);
		}

		// Token: 0x06008193 RID: 33171 RVA: 0x00023478 File Offset: 0x00021678
		[Token(Token = "0x6008193")]
		[Address(RVA = "0x17B6430", Offset = "0x17B6430", VA = "0x7BBBFB6430", Slot = "32")]
		protected virtual bool NeedShowDistance()
		{
			return default(bool);
		}

		// Token: 0x06008194 RID: 33172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008194")]
		[Address(RVA = "0x17B6438", Offset = "0x17B6438", VA = "0x7BBBFB6438", Slot = "33")]
		protected virtual void OnDistanceChanged(float distance)
		{
		}

		// Token: 0x06008195 RID: 33173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008195")]
		[Address(RVA = "0x17B643C", Offset = "0x17B643C", VA = "0x7BBBFB643C", Slot = "34")]
		protected virtual void OnHudOutScreen(OUTSCREEN_DIRCTION_TYPE OutType)
		{
		}

		// Token: 0x06008196 RID: 33174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008196")]
		[Address(RVA = "0x17B6500", Offset = "0x17B6500", VA = "0x7BBBFB6500", Slot = "35")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x06008197 RID: 33175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008197")]
		[Address(RVA = "0x17B694C", Offset = "0x17B694C", VA = "0x7BBBFB694C", Slot = "36")]
		protected virtual void UpdateNamePosition()
		{
		}

		// Token: 0x06008198 RID: 33176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008198")]
		[Address(RVA = "0x17B67E0", Offset = "0x17B67E0", VA = "0x7BBBFB67E0")]
		private void SetDistance(int distance)
		{
		}

		// Token: 0x06008199 RID: 33177 RVA: 0x00023490 File Offset: 0x00021690
		[Token(Token = "0x6008199")]
		[Address(RVA = "0x17B70A0", Offset = "0x17B70A0", VA = "0x7BBBFB70A0", Slot = "37")]
		protected virtual Vector2 GetWidgetBound()
		{
			return default(Vector2);
		}

		// Token: 0x0600819A RID: 33178 RVA: 0x000234A8 File Offset: 0x000216A8
		[Token(Token = "0x600819A")]
		[Address(RVA = "0x17B7100", Offset = "0x17B7100", VA = "0x7BBBFB7100", Slot = "38")]
		protected virtual Vector3 ExtraScreenGap()
		{
			return default(Vector3);
		}

		// Token: 0x0600819B RID: 33179 RVA: 0x000234C0 File Offset: 0x000216C0
		[Token(Token = "0x600819B")]
		[Address(RVA = "0x17B7160", Offset = "0x17B7160", VA = "0x7BBBFB7160", Slot = "39")]
		protected virtual bool IsVisibleWithZoneType(int zonetype)
		{
			return default(bool);
		}

		// Token: 0x0600819C RID: 33180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600819C")]
		[Address(RVA = "0x17B716C", Offset = "0x17B716C", VA = "0x7BBBFB716C")]
		private void OnTrainingZoneChanged(params object[] param)
		{
		}

		// Token: 0x0600819D RID: 33181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600819D")]
		[Address(RVA = "0x17B7250", Offset = "0x17B7250", VA = "0x7BBBFB7250")]
		public UIHudNameBaseController()
		{
		}

		// Token: 0x0400933E RID: 37694
		[Token(Token = "0x400933E")]
		[FieldOffset(Offset = "0x58")]
		private FollowCamera m_FollowCamera;

		// Token: 0x0400933F RID: 37695
		[Token(Token = "0x400933F")]
		[FieldOffset(Offset = "0x60")]
		protected Camera m_FollowCameraComponent;

		// Token: 0x04009340 RID: 37696
		[Token(Token = "0x4009340")]
		[FieldOffset(Offset = "0x68")]
		protected OUTSCREEN_DIRCTION_TYPE m_dirctionType;

		// Token: 0x04009341 RID: 37697
		[Token(Token = "0x4009341")]
		[FieldOffset(Offset = "0x70")]
		protected GameObject m_ArrowLeft;

		// Token: 0x04009342 RID: 37698
		[Token(Token = "0x4009342")]
		[FieldOffset(Offset = "0x78")]
		protected GameObject m_ArrowUp;

		// Token: 0x04009343 RID: 37699
		[Token(Token = "0x4009343")]
		[FieldOffset(Offset = "0x80")]
		protected GameObject m_ArrowRight;

		// Token: 0x04009344 RID: 37700
		[Token(Token = "0x4009344")]
		[FieldOffset(Offset = "0x88")]
		protected GameObject m_ArrowDown;

		// Token: 0x04009345 RID: 37701
		[Token(Token = "0x4009345")]
		[FieldOffset(Offset = "0x90")]
		protected UILabel m_DistanceLabel;

		// Token: 0x04009346 RID: 37702
		[Token(Token = "0x4009346")]
		[FieldOffset(Offset = "0x98")]
		private int m_PrevDistance;

		// Token: 0x04009347 RID: 37703
		[Token(Token = "0x4009347")]
		[FieldOffset(Offset = "0xA0")]
		private StringBuilder m_DistanceStr;
	}
}
