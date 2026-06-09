using System;
using System.Runtime.InteropServices;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C54 RID: 7252
	[Token(Token = "0x2001C54")]
	public class BountyScannerMapObject
	{
		// Token: 0x06009DC9 RID: 40393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DC9")]
		[Address(RVA = "0x14E5F60", Offset = "0x14E5F60", VA = "0x7BBBCE5F60")]
		public void OnUIInit(Transform container, UISprite markSprite, TweenAlpha markTween, float scale, UIMapUtil.EMapType mapType = UIMapUtil.EMapType.Bigmap, [Optional] UISprite directionSprite, [Optional] TweenAlpha directionTween)
		{
		}

		// Token: 0x06009DCA RID: 40394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DCA")]
		[Address(RVA = "0x14E6298", Offset = "0x14E6298", VA = "0x7BBBCE6298")]
		public void SetMinimap(UIPanel panel)
		{
		}

		// Token: 0x06009DCB RID: 40395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DCB")]
		[Address(RVA = "0x14E62AC", Offset = "0x14E62AC", VA = "0x7BBBCE62AC")]
		public void OnUIDestory()
		{
		}

		// Token: 0x06009DCC RID: 40396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DCC")]
		[Address(RVA = "0x14E63C0", Offset = "0x14E63C0", VA = "0x7BBBCE63C0")]
		private void RefreshUIView(params object[] data)
		{
		}

		// Token: 0x06009DCD RID: 40397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DCD")]
		[Address(RVA = "0x14E6708", Offset = "0x14E6708", VA = "0x7BBBCE6708")]
		private void HideBountyView(params object[] data)
		{
		}

		// Token: 0x06009DCE RID: 40398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DCE")]
		[Address(RVA = "0x14E6498", Offset = "0x14E6498", VA = "0x7BBBCE6498")]
		private void ShowMark()
		{
		}

		// Token: 0x06009DCF RID: 40399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DCF")]
		[Address(RVA = "0x14E67B0", Offset = "0x14E67B0", VA = "0x7BBBCE67B0")]
		public void ShowMarkDirection()
		{
		}

		// Token: 0x06009DD0 RID: 40400 RVA: 0x00029490 File Offset: 0x00027690
		[Token(Token = "0x6009DD0")]
		[Address(RVA = "0x14E6CF4", Offset = "0x14E6CF4", VA = "0x7BBBCE6CF4")]
		public bool IsMarkDirectionActive()
		{
			return default(bool);
		}

		// Token: 0x06009DD1 RID: 40401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DD1")]
		[Address(RVA = "0x14E660C", Offset = "0x14E660C", VA = "0x7BBBCE660C")]
		private void ShowPlayerTween()
		{
		}

		// Token: 0x06009DD2 RID: 40402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DD2")]
		[Address(RVA = "0x14E61AC", Offset = "0x14E61AC", VA = "0x7BBBCE61AC")]
		private void HideMarkerTween()
		{
		}

		// Token: 0x06009DD3 RID: 40403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DD3")]
		[Address(RVA = "0x14E6DAC", Offset = "0x14E6DAC", VA = "0x7BBBCE6DAC")]
		public BountyScannerMapObject()
		{
		}

		// Token: 0x0400A3F8 RID: 41976
		[Token(Token = "0x400A3F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Transform m_MarkContainer;

		// Token: 0x0400A3F9 RID: 41977
		[Token(Token = "0x400A3F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private UISprite m_MarkSprite;

		// Token: 0x0400A3FA RID: 41978
		[Token(Token = "0x400A3FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private UISprite m_DirectionSprite;

		// Token: 0x0400A3FB RID: 41979
		[Token(Token = "0x400A3FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TweenAlpha m_MarkerTween;

		// Token: 0x0400A3FC RID: 41980
		[Token(Token = "0x400A3FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TweenAlpha m_DirectionTween;

		// Token: 0x0400A3FD RID: 41981
		[Token(Token = "0x400A3FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private UIMapUtil.EMapType m_MapType;

		// Token: 0x0400A3FE RID: 41982
		[Token(Token = "0x400A3FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_Scale;

		// Token: 0x0400A3FF RID: 41983
		[Token(Token = "0x400A3FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private X~r^\u0082wn m_BountyManager;

		// Token: 0x0400A400 RID: 41984
		[Token(Token = "0x400A400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UIPanel m_MinimapPanel;

		// Token: 0x0400A401 RID: 41985
		[Token(Token = "0x400A401")]
		private const float MINIMAP_DIECTION_RANGE = 90f;
	}
}
