using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200151C RID: 5404
	[Token(Token = "0x200151C")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EE18C", Offset = "0x10EE18C")]
	public class UIHDLobbyYardGuideController : UIBaseController
	{
		// Token: 0x06005CD5 RID: 23765 RVA: 0x0001AFE8 File Offset: 0x000191E8
		[Token(Token = "0x6005CD5")]
		[Address(RVA = "0x16AF258", Offset = "0x16AF258", VA = "0x7BBBEAF258")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005CD6 RID: 23766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CD6")]
		[Address(RVA = "0x16AF2A8", Offset = "0x16AF2A8", VA = "0x7BBBEAF2A8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005CD7 RID: 23767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CD7")]
		[Address(RVA = "0x16AF2B0", Offset = "0x16AF2B0", VA = "0x7BBBEAF2B0", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06005CD8 RID: 23768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CD8")]
		[Address(RVA = "0x16AF2B8", Offset = "0x16AF2B8", VA = "0x7BBBEAF2B8")]
		public UIHDLobbyYardGuideController()
		{
		}

		// Token: 0x04007EBF RID: 32447
		[Token(Token = "0x4007EBF")]
		[FieldOffset(Offset = "0x58")]
		private UIHDLobbyYardGuideView m_View;

		// Token: 0x04007EC0 RID: 32448
		[Token(Token = "0x4007EC0")]
		public const string HDLOBBYYARDGUIDESHOW = "HDLobbyYardGuideShow_";

		// Token: 0x04007EC1 RID: 32449
		[Token(Token = "0x4007EC1")]
		[FieldOffset(Offset = "0x60")]
		private Vector3 m_DownTouchPos;

		// Token: 0x04007EC2 RID: 32450
		[Token(Token = "0x4007EC2")]
		private const string TargetAreaName = "AvatarRotateTouchArea";
	}
}
