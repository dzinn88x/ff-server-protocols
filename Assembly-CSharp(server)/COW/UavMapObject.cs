using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C5A RID: 7258
	[Token(Token = "0x2001C5A")]
	public class UavMapObject
	{
		// Token: 0x06009E01 RID: 40449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E01")]
		[Address(RVA = "0x17948CC", Offset = "0x17948CC", VA = "0x7BBBF948CC")]
		public void OnUIInit(Transform container, UIUAVMapObjectView uav, UISprite circle, UISprite point, TweenAlpha tweenAlpha, TweenScale tweenScale, float scale)
		{
		}

		// Token: 0x06009E02 RID: 40450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E02")]
		[Address(RVA = "0x1794C64", Offset = "0x1794C64", VA = "0x7BBBF94C64")]
		public void OnUIDestory()
		{
		}

		// Token: 0x06009E03 RID: 40451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E03")]
		[Address(RVA = "0x1794D24", Offset = "0x1794D24", VA = "0x7BBBF94D24")]
		public void OnUavCreate(params object[] data)
		{
		}

		// Token: 0x06009E04 RID: 40452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E04")]
		[Address(RVA = "0x1795454", Offset = "0x1795454", VA = "0x7BBBF95454")]
		private void UpdateUAVCircleRange()
		{
		}

		// Token: 0x06009E05 RID: 40453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E05")]
		[Address(RVA = "0x17955B4", Offset = "0x17955B4", VA = "0x7BBBF955B4")]
		public void OnUavRecycle(params object[] data)
		{
		}

		// Token: 0x06009E06 RID: 40454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E06")]
		[Address(RVA = "0x1795864", Offset = "0x1795864", VA = "0x7BBBF95864")]
		private void OnUavReveal(params object[] data)
		{
		}

		// Token: 0x06009E07 RID: 40455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E07")]
		[Address(RVA = "0x1796628", Offset = "0x1796628", VA = "0x7BBBF96628")]
		private static void NotifyLocalPlayerRevealed(bool isPersonalUAV = false)
		{
		}

		// Token: 0x06009E08 RID: 40456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E08")]
		[Address(RVA = "0x1796930", Offset = "0x1796930", VA = "0x7BBBF96930")]
		private static void UpdateLocalPlayerRevealed(LevelUAV m_Uav, bool rangeChecked, bool outRange)
		{
		}

		// Token: 0x06009E09 RID: 40457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009E09")]
		[Address(RVA = "0x1796AF0", Offset = "0x1796AF0", VA = "0x7BBBF96AF0")]
		private static Player GetLocalPlayer()
		{
			return null;
		}

		// Token: 0x06009E0A RID: 40458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E0A")]
		[Address(RVA = "0x1796C2C", Offset = "0x1796C2C", VA = "0x7BBBF96C2C")]
		public void UpdateUAVPointScale(float map_scale_ratio = 1f)
		{
		}

		// Token: 0x06009E0B RID: 40459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E0B")]
		[Address(RVA = "0x1796DF0", Offset = "0x1796DF0", VA = "0x7BBBF96DF0")]
		public void UpdateUAVPosition()
		{
		}

		// Token: 0x06009E0C RID: 40460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E0C")]
		[Address(RVA = "0x17956C0", Offset = "0x17956C0", VA = "0x7BBBF956C0")]
		private void HideUavPoints()
		{
		}

		// Token: 0x06009E0D RID: 40461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E0D")]
		[Address(RVA = "0x1796890", Offset = "0x1796890", VA = "0x7BBBF96890")]
		private void ShowPlayerTween()
		{
		}

		// Token: 0x06009E0E RID: 40462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E0E")]
		[Address(RVA = "0x1794B3C", Offset = "0x1794B3C", VA = "0x7BBBF94B3C")]
		private void HidePlayerTween()
		{
		}

		// Token: 0x06009E0F RID: 40463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E0F")]
		[Address(RVA = "0x17968E4", Offset = "0x17968E4", VA = "0x7BBBF968E4")]
		private void ShowCircleTween()
		{
		}

		// Token: 0x06009E10 RID: 40464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E10")]
		[Address(RVA = "0x1794BD0", Offset = "0x1794BD0", VA = "0x7BBBF94BD0")]
		private void HideCircleTween()
		{
		}

		// Token: 0x06009E11 RID: 40465 RVA: 0x00029538 File Offset: 0x00027738
		[Token(Token = "0x6009E11")]
		[Address(RVA = "0x179761C", Offset = "0x179761C", VA = "0x7BBBF9761C")]
		public bool IsSelf(uint uavID)
		{
			return default(bool);
		}

		// Token: 0x06009E12 RID: 40466 RVA: 0x00029550 File Offset: 0x00027750
		[Token(Token = "0x6009E12")]
		[Address(RVA = "0x17976C4", Offset = "0x17976C4", VA = "0x7BBBF976C4")]
		public bool IsRecycled()
		{
			return default(bool);
		}

		// Token: 0x06009E13 RID: 40467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E13")]
		[Address(RVA = "0x1797734", Offset = "0x1797734", VA = "0x7BBBF97734")]
		public UavMapObject()
		{
		}

		// Token: 0x0400A437 RID: 42039
		[Token(Token = "0x400A437")]
		[FieldOffset(Offset = "0x10")]
		private LevelUAV m_Uav;

		// Token: 0x0400A438 RID: 42040
		[Token(Token = "0x400A438")]
		[FieldOffset(Offset = "0x18")]
		private UIUAVMapObjectView m_UavObjectView;

		// Token: 0x0400A439 RID: 42041
		[Token(Token = "0x400A439")]
		[FieldOffset(Offset = "0x20")]
		private float m_UavFadeStartTime;

		// Token: 0x0400A43A RID: 42042
		[Token(Token = "0x400A43A")]
		[FieldOffset(Offset = "0x24")]
		private float m_UavFadeEndTime;

		// Token: 0x0400A43B RID: 42043
		[Token(Token = "0x400A43B")]
		[FieldOffset(Offset = "0x28")]
		private float m_UavFadeTime;

		// Token: 0x0400A43C RID: 42044
		[Token(Token = "0x400A43C")]
		[FieldOffset(Offset = "0x30")]
		private List<UavMapObject.UavPoint> m_UavPoints;

		// Token: 0x0400A43D RID: 42045
		[Token(Token = "0x400A43D")]
		[FieldOffset(Offset = "0x38")]
		private float m_Scale;

		// Token: 0x0400A43E RID: 42046
		[Token(Token = "0x400A43E")]
		[FieldOffset(Offset = "0x3C")]
		private float m_RangeOnMap;

		// Token: 0x0400A43F RID: 42047
		[Token(Token = "0x400A43F")]
		[FieldOffset(Offset = "0x40")]
		private float m_UAVRange;

		// Token: 0x0400A440 RID: 42048
		[Token(Token = "0x400A440")]
		[FieldOffset(Offset = "0x48")]
		private Transform m_MapContainer;

		// Token: 0x0400A441 RID: 42049
		[Token(Token = "0x400A441")]
		[FieldOffset(Offset = "0x50")]
		private UISprite m_UavPoint;

		// Token: 0x0400A442 RID: 42050
		[Token(Token = "0x400A442")]
		[FieldOffset(Offset = "0x58")]
		private TweenAlpha m_PlayerTween;

		// Token: 0x0400A443 RID: 42051
		[Token(Token = "0x400A443")]
		[FieldOffset(Offset = "0x60")]
		private TweenScale m_CircleTween;

		// Token: 0x0400A444 RID: 42052
		[Token(Token = "0x400A444")]
		[FieldOffset(Offset = "0x68")]
		private UISprite m_Circle;

		// Token: 0x0400A445 RID: 42053
		[Token(Token = "0x400A445")]
		[FieldOffset(Offset = "0x70")]
		private int m_LastUpdateFrame;

		// Token: 0x0400A446 RID: 42054
		[Token(Token = "0x400A446")]
		[FieldOffset(Offset = "0x0")]
		private static bool m_IgnoreSubsequentLocalPlayerReveal;

		// Token: 0x0400A447 RID: 42055
		[Token(Token = "0x400A447")]
		[FieldOffset(Offset = "0x78")]
		public BitArrayBoolean m_IsVisible;

		// Token: 0x0400A448 RID: 42056
		[Token(Token = "0x400A448")]
		protected const uint ISVISIBLE_ALL = 1U;

		// Token: 0x0400A449 RID: 42057
		[Token(Token = "0x400A449")]
		protected const uint ISVISIBLE_OWNER = 2U;

		// Token: 0x0400A44A RID: 42058
		[Token(Token = "0x400A44A")]
		protected const uint ISVISIBLE_TEAMMATE = 4U;

		// Token: 0x0400A44B RID: 42059
		[Token(Token = "0x400A44B")]
		protected const uint ISVISIBLE_REVEAL = 8U;

		// Token: 0x0400A44C RID: 42060
		[Token(Token = "0x400A44C")]
		[FieldOffset(Offset = "0x80")]
		private Color MyTeamUAVColor;

		// Token: 0x0400A44D RID: 42061
		[Token(Token = "0x400A44D")]
		[FieldOffset(Offset = "0x90")]
		private Color EnemyUAVColor;

		// Token: 0x0400A44E RID: 42062
		[Token(Token = "0x400A44E")]
		[FieldOffset(Offset = "0xA0")]
		private Color GlobalEventUAVColor;

		// Token: 0x02001C5B RID: 7259
		[Token(Token = "0x2001C5B")]
		private class UavPoint
		{
			// Token: 0x06009E14 RID: 40468 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009E14")]
			[Address(RVA = "0x17968DC", Offset = "0x17968DC", VA = "0x7BBBF968DC")]
			public UavPoint()
			{
			}

			// Token: 0x0400A44F RID: 42063
			[Token(Token = "0x400A44F")]
			[FieldOffset(Offset = "0x10")]
			public UISprite Sprite;

			// Token: 0x0400A450 RID: 42064
			[Token(Token = "0x400A450")]
			[FieldOffset(Offset = "0x18")]
			public TweenAlpha TweenAlpha;

			// Token: 0x0400A451 RID: 42065
			[Token(Token = "0x400A451")]
			[FieldOffset(Offset = "0x20")]
			public Transform SpriteTrans;
		}
	}
}
