using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200217B RID: 8571
	[Token(Token = "0x200217B")]
	public class UICollectionView : UIBaseView
	{
		// Token: 0x0600BE06 RID: 48646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE06")]
		[Address(RVA = "0x20AE340", Offset = "0x20AE340", VA = "0x7BBC8AE340", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE07 RID: 48647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE07")]
		[Address(RVA = "0x20AEE7C", Offset = "0x20AEE7C", VA = "0x7BBC8AEE7C")]
		public UICollectionView()
		{
		}

		// Token: 0x0400C747 RID: 51015
		[Token(Token = "0x400C747")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget PreviewContainer;

		// Token: 0x0400C748 RID: 51016
		[Token(Token = "0x400C748")]
		[FieldOffset(Offset = "0x28")]
		public GameObject Preview;

		// Token: 0x0400C749 RID: 51017
		[Token(Token = "0x400C749")]
		[FieldOffset(Offset = "0x30")]
		public GameObject callsignPreview;

		// Token: 0x0400C74A RID: 51018
		[Token(Token = "0x400C74A")]
		[FieldOffset(Offset = "0x38")]
		public Transform PreviewPosNormal;

		// Token: 0x0400C74B RID: 51019
		[Token(Token = "0x400C74B")]
		[FieldOffset(Offset = "0x40")]
		public Transform PreviewPosPin;

		// Token: 0x0400C74C RID: 51020
		[Token(Token = "0x400C74C")]
		[FieldOffset(Offset = "0x48")]
		public Transform profilePreview;

		// Token: 0x0400C74D RID: 51021
		[Token(Token = "0x400C74D")]
		[FieldOffset(Offset = "0x50")]
		public UILabel nickname;

		// Token: 0x0400C74E RID: 51022
		[Token(Token = "0x400C74E")]
		[FieldOffset(Offset = "0x58")]
		public GameObject fakebg;

		// Token: 0x0400C74F RID: 51023
		[Token(Token = "0x400C74F")]
		[FieldOffset(Offset = "0x60")]
		public UISprite briefbg;

		// Token: 0x0400C750 RID: 51024
		[Token(Token = "0x400C750")]
		[FieldOffset(Offset = "0x68")]
		public UISprite IconBriefPin;

		// Token: 0x0400C751 RID: 51025
		[Token(Token = "0x400C751")]
		[FieldOffset(Offset = "0x70")]
		public UISprite IconBigPin;

		// Token: 0x0400C752 RID: 51026
		[Token(Token = "0x400C752")]
		[FieldOffset(Offset = "0x78")]
		public GameObject CallsignConfig;

		// Token: 0x0400C753 RID: 51027
		[Token(Token = "0x400C753")]
		[FieldOffset(Offset = "0x80")]
		public UICheckboxButton CallsignCheckboxBtn;

		// Token: 0x0400C754 RID: 51028
		[Token(Token = "0x400C754")]
		[FieldOffset(Offset = "0x88")]
		public UIButton HelpBtn;

		// Token: 0x0400C755 RID: 51029
		[Token(Token = "0x400C755")]
		[FieldOffset(Offset = "0x90")]
		public GameObject Preview3D;

		// Token: 0x0400C756 RID: 51030
		[Token(Token = "0x400C756")]
		[FieldOffset(Offset = "0x98")]
		public UILabel noPreviewTips;

		// Token: 0x0400C757 RID: 51031
		[Token(Token = "0x400C757")]
		[FieldOffset(Offset = "0xA0")]
		public UIButton equipBtn;

		// Token: 0x0400C758 RID: 51032
		[Token(Token = "0x400C758")]
		[FieldOffset(Offset = "0xA8")]
		public UILabel btnName;

		// Token: 0x0400C759 RID: 51033
		[Token(Token = "0x400C759")]
		[FieldOffset(Offset = "0xB0")]
		public UIButton unEquipBtn;

		// Token: 0x0400C75A RID: 51034
		[Token(Token = "0x400C75A")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject EmotePreview;

		// Token: 0x0400C75B RID: 51035
		[Token(Token = "0x400C75B")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject EmoteConfig;

		// Token: 0x0400C75C RID: 51036
		[Token(Token = "0x400C75C")]
		[FieldOffset(Offset = "0xC8")]
		public UICheckboxButton EmoteCheckboxBtn;

		// Token: 0x0400C75D RID: 51037
		[Token(Token = "0x400C75D")]
		[FieldOffset(Offset = "0xD0")]
		public UIWidget EmoteCheckWidget;

		// Token: 0x0400C75E RID: 51038
		[Token(Token = "0x400C75E")]
		[FieldOffset(Offset = "0xD8")]
		public UILabel LabelFlightHint;

		// Token: 0x0400C75F RID: 51039
		[Token(Token = "0x400C75F")]
		[FieldOffset(Offset = "0xE0")]
		public Transform LeftTabContainer;

		// Token: 0x0400C760 RID: 51040
		[Token(Token = "0x400C760")]
		[FieldOffset(Offset = "0xE8")]
		public Transform CollectionContainer;

		// Token: 0x0400C761 RID: 51041
		[Token(Token = "0x400C761")]
		[FieldOffset(Offset = "0xF0")]
		public UILabel navigation;

		// Token: 0x0400C762 RID: 51042
		[Token(Token = "0x400C762")]
		[FieldOffset(Offset = "0xF8")]
		public UIWidget collectionBg;

		// Token: 0x0400C763 RID: 51043
		[Token(Token = "0x400C763")]
		[FieldOffset(Offset = "0x100")]
		public UIWidget collectionbg;

		// Token: 0x0400C764 RID: 51044
		[Token(Token = "0x400C764")]
		[FieldOffset(Offset = "0x108")]
		public UILabel LabelNoItem;

		// Token: 0x0400C765 RID: 51045
		[Token(Token = "0x400C765")]
		[FieldOffset(Offset = "0x110")]
		public GameObject vehicleContainer;

		// Token: 0x0400C766 RID: 51046
		[Token(Token = "0x400C766")]
		[FieldOffset(Offset = "0x118")]
		public UIWidget weaponBg;

		// Token: 0x0400C767 RID: 51047
		[Token(Token = "0x400C767")]
		[FieldOffset(Offset = "0x120")]
		public UIWidget weaponbg;

		// Token: 0x0400C768 RID: 51048
		[Token(Token = "0x400C768")]
		[FieldOffset(Offset = "0x128")]
		public GameObject GeneralContainer;

		// Token: 0x0400C769 RID: 51049
		[Token(Token = "0x400C769")]
		[FieldOffset(Offset = "0x130")]
		public GameObject SourceTypeMenuPosition;

		// Token: 0x0400C76A RID: 51050
		[Token(Token = "0x400C76A")]
		[FieldOffset(Offset = "0x138")]
		public UIScrollView GeneralContainerScroll;

		// Token: 0x0400C76B RID: 51051
		[Token(Token = "0x400C76B")]
		[FieldOffset(Offset = "0x140")]
		public UIEasyList GeneralGrid;

		// Token: 0x0400C76C RID: 51052
		[Token(Token = "0x400C76C")]
		[FieldOffset(Offset = "0x148")]
		public Transform SelectedEmoteContainer;

		// Token: 0x0400C76D RID: 51053
		[Token(Token = "0x400C76D")]
		[FieldOffset(Offset = "0x150")]
		public UIWidget SelectKItembg;

		// Token: 0x0400C76E RID: 51054
		[Token(Token = "0x400C76E")]
		[FieldOffset(Offset = "0x158")]
		public UILabel LabelSummary;

		// Token: 0x0400C76F RID: 51055
		[Token(Token = "0x400C76F")]
		[FieldOffset(Offset = "0x160")]
		public UILabel LabelEmoteHint;

		// Token: 0x0400C770 RID: 51056
		[Token(Token = "0x400C770")]
		[FieldOffset(Offset = "0x168")]
		public UIWidget SelectKItemBg;

		// Token: 0x0400C771 RID: 51057
		[Token(Token = "0x400C771")]
		[FieldOffset(Offset = "0x170")]
		public GameObject EmoteListRoot;

		// Token: 0x0400C772 RID: 51058
		[Token(Token = "0x400C772")]
		[FieldOffset(Offset = "0x178")]
		public UISprite EmoteListBg;

		// Token: 0x0400C773 RID: 51059
		[Token(Token = "0x400C773")]
		[FieldOffset(Offset = "0x180")]
		public UIWidget PreviewLeftContainer;

		// Token: 0x0400C774 RID: 51060
		[Token(Token = "0x400C774")]
		[FieldOffset(Offset = "0x188")]
		public UIWidget PreviewRightContainer;

		// Token: 0x0400C775 RID: 51061
		[Token(Token = "0x400C775")]
		[FieldOffset(Offset = "0x190")]
		public GameObject weaponContainer;

		// Token: 0x0400C776 RID: 51062
		[Token(Token = "0x400C776")]
		[FieldOffset(Offset = "0x198")]
		public GameObject EmoteTrashContainer;
	}
}
