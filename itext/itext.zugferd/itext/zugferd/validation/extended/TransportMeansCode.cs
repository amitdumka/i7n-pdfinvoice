/*
    This file is part of the iText (R) project.
    Copyright (c) 1998-2017 iText Group NV
    Authors: iText Software.

    This program is free software; you can redistribute it and/or modify
    it under the terms of the GNU Affero General Public License version 3
    as published by the Free Software Foundation with the addition of the
    following permission added to Section 15 as permitted in Section 7(a):
    FOR ANY PART OF THE COVERED WORK IN WHICH THE COPYRIGHT IS OWNED BY
    ITEXT GROUP. ITEXT GROUP DISCLAIMS THE WARRANTY OF NON INFRINGEMENT
    OF THIRD PARTY RIGHTS

    This program is distributed in the hope that it will be useful, but
    WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
    or FITNESS FOR A PARTICULAR PURPOSE.
    See the GNU Affero General Public License for more details.
    You should have received a copy of the GNU Affero General Public License
    along with this program; if not, see http://www.gnu.org/licenses or write to
    the Free Software Foundation, Inc., 51 Franklin Street, Fifth Floor,
    Boston, MA, 02110-1301 USA, or download the license from the following URL:
    http://itextpdf.com/terms-of-use/

    The interactive user interfaces in modified source and object code versions
    of this program must display Appropriate Legal Notices, as required under
    Section 5 of the GNU Affero General Public License.

    In accordance with Section 7(b) of the GNU Affero General Public License,
    a covered work must retain the producer line in every PDF that is created
    or manipulated using iText.

    You can be released from the requirements of the license by purchasing
    a commercial license. Buying such a license is mandatory as soon as you
    develop commercial activities involving the iText software without
    disclosing the source code of your own applications.
    These activities include: offering paid services to customers as an ASP,
    serving PDFs on the fly in a web application, shipping iText with a closed
    source product.

    For more information, please contact iText Software Corp. at this
    address: sales@itextpdf.com */
using System;
using iText.Zugferd.Validation;

namespace iText.Zugferd.Validation.Extended {
    /// <summary>Series of codes that can be used for transport identification.</summary>
    /// <remarks>
    /// Series of codes that can be used for transport identification.
    /// These codes are used only in the context of the Extended profile.
    /// </remarks>
    public class TransportMeansCode : CodeValidation {
        public const String MARITIME = "1";

        public const String RAIL = "2";

        public const String ROAD = "3";

        public const String AIR = "4";

        public const String MAIL = "5";

        public const String MULTIMODAL = "6";

        public const String FIXED_INSTALLATION = "7";

        public const String INLAND_WATER = "8";

        public const String NOT_APPLICABLE = "9";

        public override bool IsValid(String code) {
            return code.Equals(MARITIME) || code.Equals(RAIL) || code.Equals(ROAD) || code.Equals(AIR) || code.Equals(
                MAIL) || code.Equals(MULTIMODAL) || code.Equals(FIXED_INSTALLATION) || code.Equals(INLAND_WATER) || code
                .Equals(NOT_APPLICABLE);
        }
    }
}
